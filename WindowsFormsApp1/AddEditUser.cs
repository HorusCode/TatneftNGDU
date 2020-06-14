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
using System.Text.RegularExpressions;
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

        private bool validateInput()
        {
            if(userFirstname.Text.Trim().Length < 2)
            {
                showError("В фамилии минимум 2 символа");
                return false;
            }

            if (userSecondname.Text.Trim().Length < 2)
            {
                showError("В имени минимум 2 символа");
                return false;
            }

            if (userPatronymic.Text.Trim().Length < 2)
            {
                showError("В отчестве минимум 2 символа");
                return false;
            }
            if (!int.TryParse(userPassportNumber.Text, out int value))
            {
                showError("Только цифры в номере паспорта!");
                return false;
            }
            if (userPassportNumber.Text.Length != 6)
            {
                showError("Должно быть 6 цифр в номере паспорта!");
                return false;
            }
            if (!int.TryParse(userPassportSeries.Text, out value))
            {
                showError("Только цифры в серии паспорта!");
                return false;
            }
            if (userPassportNumber.Text.Length != 4)
            {
                showError("Должно быть 4 цифры в серии паспорта!");
                return false;
            }
            if (userPlaceliving.Text.Trim().Length < 10)
            {
                showError("Минимум 10 символов в месте проживания");
                return false;
            }
            if (userPassportPlace.Text.Trim().Length < 10)
            {
                showError("Минимум 10 символов в месте получения паспорта");
                return false;
            }
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";


            if (!Regex.IsMatch(userEmail.Text, pattern))
            {
                showError("Введите корректную почту");
                return false;
            }
            
            return true;
        }

        private void showError(string message)
        {
            errorMessage.Text = message;
            errorPanel.Visible = true;
            timer.Start();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            

            if(validateInput())
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

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            errorPanel.Visible = false;
        }
    }
}
