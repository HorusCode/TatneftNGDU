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
                    "Редактировать",
                    "Уволить",
                    "Переквалифицировать"
                });
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
    }
}
