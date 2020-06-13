using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Micron;
using Data.Models;

namespace WindowsFormsApp1
{
    public partial class Auth : Form
    {

        MicronDbContext micron = new MicronDbContext();

        public Auth()
        {
            InitializeComponent();
          
        }

      

        private void emailInput_Leave(object sender, EventArgs e)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";


            if (emailInput.Text == "")
            {
                errorProvider.SetError(emailInput, "Поле не должно быть пустым");
            }
            else if(!Regex.IsMatch(emailInput.Text, pattern))
            {
                errorProvider.SetError(emailInput, "Неверный формат почты");
            }
            else
            {
                errorProvider.SetError(emailInput, null);
            }
        }

        private void passwordInput_Leave(object sender, EventArgs e)
        {
            if (passwordInput.Text == "")
            {
                errorProvider.SetError(passwordInput, "Поле не должно быть пустым");
            }
            else
            {
                errorProvider.SetError(passwordInput, null);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                User user = micron.GetRecord<User>($"email='{emailInput.Text}' AND password='{passwordInput.Text}'");
                if(user == null)
                {
                    MessageBox.Show("Такой пользователь не найден", "Ошибка при входе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Visible = false;

                var App = new App(user);
                App.ShowDialog();
                if (App.DialogResult != DialogResult.No) this.Close();

                this.Visible = true;
            
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
