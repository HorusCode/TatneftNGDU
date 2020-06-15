using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class App : Form
    {
        public App(User user)
        {
            InitializeComponent();
            AddControlsPanel(new WorkersTableControl());
            userFullName.Text = user.FullName;
            userRole.Text = user.GetRole().name;
        }


        private void moveSidebarDivider(Control btn)
        {
            sidebarDivider.Top = btn.Top;
            sidebarDivider.Height = btn.Height;
        }

        private void AddControlsPanel(Control control)
        {
            control.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(control);
        }


        private void usersBtn_Click(object sender, EventArgs e)
        {
            moveSidebarDivider(usersBtn);
            AddControlsPanel(new WorkersTableControl());
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void firedUsersBtn_Click(object sender, EventArgs e)
        {
            moveSidebarDivider(firedUsersBtn);
            AddControlsPanel(new FiredUsersTableControl());
        }

        private void retrainingUsersBtn_Click(object sender, EventArgs e)
        {
            moveSidebarDivider(retrainingUsersBtn);
            AddControlsPanel(new RetariningUsersTableControl());
        }
    }
}
