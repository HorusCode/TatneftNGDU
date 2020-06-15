namespace WindowsFormsApp1.UserControls
{
    partial class RetariningUsersTableControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersTable.BackgroundColor = System.Drawing.Color.White;
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeight = 45;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.specialization,
            this.created_at});
            this.usersTable.DoubleBuffered = true;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.GridColor = System.Drawing.Color.White;
            this.usersTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.usersTable.HeaderForeColor = System.Drawing.Color.White;
            this.usersTable.Location = new System.Drawing.Point(3, 3);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.Size = new System.Drawing.Size(1092, 573);
            this.usersTable.TabIndex = 1;
            // 
            // fullName
            // 
            this.fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullName.FillWeight = 44.59228F;
            this.fullName.HeaderText = "ФИО";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // specialization
            // 
            this.specialization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialization.FillWeight = 44.59228F;
            this.specialization.HeaderText = "Специальность";
            this.specialization.MinimumWidth = 6;
            this.specialization.Name = "specialization";
            this.specialization.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_at.HeaderText = "Дата переквалификации";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // RetariningUsersTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersTable);
            this.Name = "RetariningUsersTableControl";
            this.Size = new System.Drawing.Size(1107, 579);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid usersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}
