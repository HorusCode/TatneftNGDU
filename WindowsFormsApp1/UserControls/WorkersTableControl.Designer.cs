namespace WindowsFormsApp1.UserControls
{
    partial class WorkersTableControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersTableControl));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.usersTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.retraining = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchData = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.newUserBtn = new XanderUI.XUIButton();
            this.reloadBtn = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.usersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.White;
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.usersTable.ColumnHeadersHeight = 45;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.stage,
            this.specialization,
            this.edit,
            this.delete,
            this.retraining});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.usersTable.DoubleBuffered = true;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.GridColor = System.Drawing.Color.White;
            this.usersTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.usersTable.HeaderForeColor = System.Drawing.Color.White;
            this.usersTable.Location = new System.Drawing.Point(10, 64);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.Size = new System.Drawing.Size(1083, 507);
            this.usersTable.TabIndex = 0;
            this.usersTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.usersTable_CellPainting);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.usersTable;
            // 
            // fullName
            // 
            this.fullName.FillWeight = 44.59228F;
            this.fullName.HeaderText = "ФИО";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // stage
            // 
            this.stage.FillWeight = 44.59228F;
            this.stage.HeaderText = "Стаж";
            this.stage.MinimumWidth = 6;
            this.stage.Name = "stage";
            this.stage.ReadOnly = true;
            // 
            // specialization
            // 
            this.specialization.FillWeight = 44.59228F;
            this.specialization.HeaderText = "Специальность";
            this.specialization.MinimumWidth = 6;
            this.specialization.Name = "specialization";
            this.specialization.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.FillWeight = 20F;
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 20F;
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // retraining
            // 
            this.retraining.FillWeight = 20F;
            this.retraining.HeaderText = "";
            this.retraining.MinimumWidth = 6;
            this.retraining.Name = "retraining";
            this.retraining.ReadOnly = true;
            // 
            // searchData
            // 
            this.searchData.AcceptsReturn = false;
            this.searchData.AcceptsTab = false;
            this.searchData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchData.AnimationSpeed = 200;
            this.searchData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchData.BackColor = System.Drawing.Color.Transparent;
            this.searchData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchData.BackgroundImage")));
            this.searchData.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchData.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchData.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchData.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchData.BorderRadius = 1;
            this.searchData.BorderThickness = 1;
            this.searchData.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchData.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.searchData.DefaultText = "";
            this.searchData.FillColor = System.Drawing.Color.White;
            this.searchData.HideSelection = true;
            this.searchData.IconLeft = null;
            this.searchData.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchData.IconPadding = 10;
            this.searchData.IconRight = ((System.Drawing.Image)(resources.GetObject("searchData.IconRight")));
            this.searchData.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchData.Lines = new string[0];
            this.searchData.Location = new System.Drawing.Point(644, 13);
            this.searchData.MaxLength = 32767;
            this.searchData.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchData.Modified = false;
            this.searchData.Multiline = false;
            this.searchData.Name = "searchData";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchData.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Empty;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchData.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchData.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchData.OnIdleState = stateProperties12;
            this.searchData.PasswordChar = '\0';
            this.searchData.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchData.PlaceholderText = "Поиск...";
            this.searchData.ReadOnly = false;
            this.searchData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchData.SelectedText = "";
            this.searchData.SelectionLength = 0;
            this.searchData.SelectionStart = 0;
            this.searchData.ShortcutsEnabled = true;
            this.searchData.Size = new System.Drawing.Size(449, 33);
            this.searchData.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.searchData.TabIndex = 1;
            this.searchData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchData.TextMarginBottom = 0;
            this.searchData.TextMarginLeft = 5;
            this.searchData.TextMarginTop = 0;
            this.searchData.TextPlaceholder = "Поиск...";
            this.searchData.UseSystemPasswordChar = false;
            this.searchData.WordWrap = true;
            this.searchData.TextChange += new System.EventHandler(this.searchData_TextChange);
            // 
            // newUserBtn
            // 
            this.newUserBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.newUserBtn.ButtonImage = null;
            this.newUserBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.newUserBtn.ButtonText = "Добавить";
            this.newUserBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(85)))));
            this.newUserBtn.ClickTextColor = System.Drawing.Color.White;
            this.newUserBtn.CornerRadius = 5;
            this.newUserBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newUserBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.newUserBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.newUserBtn.HoverTextColor = System.Drawing.Color.White;
            this.newUserBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.newUserBtn.Location = new System.Drawing.Point(13, 8);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(123, 50);
            this.newUserBtn.TabIndex = 2;
            this.newUserBtn.TextColor = System.Drawing.Color.White;
            this.newUserBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.reloadBtn.ButtonImage = null;
            this.reloadBtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.reloadBtn.ButtonText = "Обновить";
            this.reloadBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.reloadBtn.ClickTextColor = System.Drawing.Color.White;
            this.reloadBtn.CornerRadius = 5;
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.reloadBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.reloadBtn.HoverTextColor = System.Drawing.Color.White;
            this.reloadBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.reloadBtn.Location = new System.Drawing.Point(142, 8);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(123, 50);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.TextColor = System.Drawing.Color.White;
            this.reloadBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // WorkersTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.usersTable);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WorkersTableControl";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1107, 579);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid usersTable;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn retraining;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchData;
        private XanderUI.XUIButton newUserBtn;
        private XanderUI.XUIButton reloadBtn;
    }
}
