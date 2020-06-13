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
                    user.id, 
                    user.firstname + " " + user.secondname + " " + user.patronymic,
                    (int)date.Subtract(user.created_at).Days / 365, 
                    user.GetRole().name
                });
            }

        }
    }
}
