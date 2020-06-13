namespace WindowsFormsApp1
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closeApp = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarDivider = new System.Windows.Forms.Panel();
            this.usersBtn = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userFullName = new System.Windows.Forms.Label();
            this.userRole = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logoutBtn = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // closeApp
            // 
            this.closeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeApp.BackColor = System.Drawing.Color.Transparent;
            this.closeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeApp.Image = ((System.Drawing.Image)(resources.GetObject("closeApp.Image")));
            this.closeApp.ImageActive = null;
            this.closeApp.Location = new System.Drawing.Point(928, 16);
            this.closeApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(35, 41);
            this.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeApp.TabIndex = 10;
            this.closeApp.TabStop = false;
            this.closeApp.Zoom = 10;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.sidebarDivider);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 700);
            this.panel1.TabIndex = 11;
            // 
            // sidebarDivider
            // 
            this.sidebarDivider.BackColor = System.Drawing.Color.White;
            this.sidebarDivider.Location = new System.Drawing.Point(0, 74);
            this.sidebarDivider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebarDivider.Name = "sidebarDivider";
            this.sidebarDivider.Size = new System.Drawing.Size(6, 53);
            this.sidebarDivider.TabIndex = 1;
            // 
            // usersBtn
            // 
            this.usersBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.usersBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("usersBtn.ButtonImage")));
            this.usersBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.usersBtn.ButtonText = "Все сотрудники";
            this.usersBtn.ClickBackColor = System.Drawing.Color.Transparent;
            this.usersBtn.ClickTextColor = System.Drawing.Color.White;
            this.usersBtn.CornerRadius = 5;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.usersBtn.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.usersBtn.HoverTextColor = System.Drawing.Color.White;
            this.usersBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.usersBtn.Location = new System.Drawing.Point(14, 74);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(199, 52);
            this.usersBtn.TabIndex = 0;
            this.usersBtn.TextColor = System.Drawing.Color.White;
            this.usersBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // userFullName
            // 
            this.userFullName.AutoSize = true;
            this.userFullName.Location = new System.Drawing.Point(52, 12);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(63, 23);
            this.userFullName.TabIndex = 13;
            this.userFullName.Text = "{name}";
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Location = new System.Drawing.Point(53, 34);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(49, 23);
            this.userRole.TabIndex = 14;
            this.userRole.Text = "{role}";
            // 
            // header
            // 
            this.header.Controls.Add(this.userRole);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.closeApp);
            this.header.Controls.Add(this.userFullName);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(225, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(975, 69);
            this.header.TabIndex = 15;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(225, 69);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(975, 631);
            this.container.TabIndex = 16;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.header;
            this.bunifuDragControl.Vertical = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.ButtonImage")));
            this.logoutBtn.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.logoutBtn.ButtonText = "Выход";
            this.logoutBtn.ClickBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ClickTextColor = System.Drawing.Color.White;
            this.logoutBtn.CornerRadius = 5;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.logoutBtn.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.logoutBtn.HoverTextColor = System.Drawing.Color.White;
            this.logoutBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.logoutBtn.Location = new System.Drawing.Point(14, 644);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(199, 52);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.TextColor = System.Drawing.Color.White;
            this.logoutBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.container);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "App";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton closeApp;
        private System.Windows.Forms.Panel sidebarDivider;
        private XanderUI.XUIButton usersBtn;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label userFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel container;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private XanderUI.XUIButton logoutBtn;
    }
}