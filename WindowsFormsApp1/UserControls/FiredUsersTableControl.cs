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
    public partial class FiredUsersTableControl : UserControl
    {
        MicronDbContext micron = new MicronDbContext();
        public FiredUsersTableControl()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            var users = from user in micron.GetRecords<User>()
                                                          join role in micron.GetRecords<Role>()
                                                          on user.role_id equals role.id
                                                          where role.name != "operator"
                                                          join fired in micron.GetRecords<Fire>()
                                                          on user.id equals fired.user_id
                                                          where fired.status == 0
                                                          select new
                                                          {
                                                              user = user,
                                                              created_at = fired.created_at
                                                          };

            usersTable.Rows.Clear();

            DateTime date = DateTime.Now;



            foreach (var row in users)
            {

                usersTable.Rows.Add(new object[] {
                    row.user.FullName,
                    row.user.GetRole().name,
                    row.created_at
                 });


                    usersTable.Rows[usersTable.RowCount - 1].Tag = row.user;
            }

        }

    }

}
