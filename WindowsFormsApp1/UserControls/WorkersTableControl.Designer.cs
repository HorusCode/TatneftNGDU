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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.retraining = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.White;
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeight = 45;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullName,
            this.stage,
            this.specialization,
            this.edit,
            this.delete,
            this.retraining});
            this.usersTable.DoubleBuffered = true;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.usersTable.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.usersTable.Location = new System.Drawing.Point(15, 54);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.Size = new System.Drawing.Size(881, 507);
            this.usersTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.FillWeight = 44.59228F;
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.usersTable;
            // 
            // WorkersTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersTable);
            this.Name = "WorkersTableControl";
            this.Size = new System.Drawing.Size(907, 564);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid usersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn retraining;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
