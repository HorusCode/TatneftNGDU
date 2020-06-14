using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;
using Data.Models;

namespace WindowsFormsApp1.UserControls
{

        public partial class WorkersTableControl : UserControl
    {
        MicronDbContext micron = new MicronDbContext();
        public WorkersTableControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            IEnumerable<User> users = from user in micron.GetRecords<User>()
                                      join role in micron.GetRecords<Role>()
                                      on user.role_id equals role.id
                                      where role.name != "operator"
                                      select user;

            usersTable.Rows.Clear();

            DateTime date = DateTime.Now;

            

            foreach (var user in users)
            {
                usersTable.Rows.Add(new object[] {
                    user.FullName,
                    (int)(date - user.created_at).TotalDays / 365 + " лет", 
                    user.GetRole().name,
                    "Ред.",
                    "Увол.",
                    "Перекв."
                });

                usersTable.Rows[usersTable.RowCount - 1].Tag = user;
            }
           
        }


     
        private void usersTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.White;
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                using (var b = new SolidBrush(BackColor))
                {
                   
                    e.PaintBackground(e.CellBounds, false);

                    
                    TextRenderer.DrawText(e.Graphics, string.Format("{0}", e.FormattedValue),
                        e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                   
                    if (grid.SortedColumn?.Index == e.ColumnIndex)
                    {
                        var sortIcon = grid.SortOrder == SortOrder.Ascending ? "▲" : "▼";

                        
                        TextRenderer.DrawText(e.Graphics, sortIcon,
                            e.CellStyle.Font, e.CellBounds, sortIconColor,
                            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                    }

                    
                    e.Handled = true;
                }
            }
        }

        private void searchData_TextChange(object sender, EventArgs e)
        {
            string search = searchData.Text;
            usersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in usersTable.Rows)
            {
                for(int i = 0; i < row.Cells.Count - 3; i++) // Чтобы не искал кнопки
                {
                    if (row.Cells[i].Value.ToString().Like(search))
                    {
                        row.Selected = true;
                        break;
                    } else
                    {
                        row.Selected = false;
                    }
                }
                
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            new AddEditUser(null).Show();
        }

        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //edit
            {
                new AddEditUser((User)usersTable.CurrentRow.Tag).ShowDialog();
                LoadData();
            }
           
        }
    }
}
