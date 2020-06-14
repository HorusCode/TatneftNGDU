using Data.Models;
using Micron;
using SqlKata;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddEditUser : Form
    {

        MicronDbContext micron = new MicronDbContext();

        public AddEditUser()
        {
            InitializeComponent();

            userBirthday.MaxDate = DateTime.Now.AddYears(-18);
            createdAt.Text = $"Дата устройства: {DateTime.Now.ToShortDateString()}";

            IEnumerable<Role> roles = micron.GetRecords<Role>();
            foreach (var role in roles)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = role.name;
                item.Value = role.id;
                userRole.Items.Add(item);
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var compiller = new MySqlCompiler();

            var query = new Query("users").AsInsert(new
            {
                patronymic = userPatronymic.Text,
                secondname = userSecondname.Text,
                firstname = userFirstname.Text,
                birthday = userBirthday.Value,
                role_id = (userRole.SelectedItem as ComboboxItem).Value.ToString(),
                placeliving = userPlaceliving.Text,
                passport_series = userPassportSeries.Text,
                passport_number = userPassportNumber.Text,
                passport_place = userPassportPlace.Text,
                email = userEmail.Text,
            });

           
            micron.Exec(compiller.Compile(query).ToString());
        }
    }
}
