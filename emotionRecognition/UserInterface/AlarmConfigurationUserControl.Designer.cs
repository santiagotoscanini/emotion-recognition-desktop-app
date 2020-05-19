namespace UserInterface
{
    partial class AlarmConfigurationUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPostsAmount = new System.Windows.Forms.TextBox();
            this.TxtTimeFrame = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.RdoHours = new System.Windows.Forms.RadioButton();
            this.RdoDays = new System.Windows.Forms.RadioButton();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblPosts = new System.Windows.Forms.Label();
            this.RdoNegative = new System.Windows.Forms.RadioButton();
            this.RdoPositive = new System.Windows.Forms.RadioButton();
            this.LblAlarmType = new System.Windows.Forms.Label();
            this.CboEntity = new System.Windows.Forms.ComboBox();
            this.LblEntity = new System.Windows.Forms.Label();
            this.LblErrorMassage = new System.Windows.Forms.Label();
            this.PnlAlarmType = new System.Windows.Forms.Panel();
            this.PnlAlarmType.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPostsAmount
            // 
            this.TxtPostsAmount.Location = new System.Drawing.Point(39, 176);
            this.TxtPostsAmount.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPostsAmount.Name = "TxtPostsAmount";
            this.TxtPostsAmount.Size = new System.Drawing.Size(301, 20);
            this.TxtPostsAmount.TabIndex = 29;
            this.TxtPostsAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPostsAmount_KeyPress);
            // 
            // TxtTimeFrame
            // 
            this.TxtTimeFrame.Location = new System.Drawing.Point(39, 250);
            this.TxtTimeFrame.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTimeFrame.Name = "TxtTimeFrame";
            this.TxtTimeFrame.Size = new System.Drawing.Size(145, 20);
            this.TxtTimeFrame.TabIndex = 28;
            this.TxtTimeFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTimeFrame_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(434, 270);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 29);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // RdoHours
            // 
            this.RdoHours.AutoSize = true;
            this.RdoHours.Location = new System.Drawing.Point(287, 250);
            this.RdoHours.Margin = new System.Windows.Forms.Padding(2);
            this.RdoHours.Name = "RdoHours";
            this.RdoHours.Size = new System.Drawing.Size(53, 17);
            this.RdoHours.TabIndex = 26;
            this.RdoHours.TabStop = true;
            this.RdoHours.Text = "Horas";
            this.RdoHours.UseVisualStyleBackColor = true;
            // 
            // RdoDays
            // 
            this.RdoDays.AutoSize = true;
            this.RdoDays.Checked = true;
            this.RdoDays.Location = new System.Drawing.Point(212, 252);
            this.RdoDays.Margin = new System.Windows.Forms.Padding(2);
            this.RdoDays.Name = "RdoDays";
            this.RdoDays.Size = new System.Drawing.Size(46, 17);
            this.RdoDays.TabIndex = 25;
            this.RdoDays.TabStop = true;
            this.RdoDays.Text = "Dias";
            this.RdoDays.UseVisualStyleBackColor = true;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(36, 224);
            this.LblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(85, 13);
            this.LblTime.TabIndex = 24;
            this.LblTime.Text = "Plazo de tiempo:";
            // 
            // LblPosts
            // 
            this.LblPosts.AutoSize = true;
            this.LblPosts.Location = new System.Drawing.Point(36, 151);
            this.LblPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPosts.Name = "LblPosts";
            this.LblPosts.Size = new System.Drawing.Size(165, 13);
            this.LblPosts.TabIndex = 23;
            this.LblPosts.Text = "Cantidad de posts para activarse:";
            // 
            // RdoNegative
            // 
            this.RdoNegative.AutoSize = true;
            this.RdoNegative.Location = new System.Drawing.Point(118, 16);
            this.RdoNegative.Margin = new System.Windows.Forms.Padding(2);
            this.RdoNegative.Name = "RdoNegative";
            this.RdoNegative.Size = new System.Drawing.Size(68, 17);
            this.RdoNegative.TabIndex = 22;
            this.RdoNegative.TabStop = true;
            this.RdoNegative.Text = "Negativo";
            this.RdoNegative.UseVisualStyleBackColor = true;
            this.RdoNegative.CheckedChanged += new System.EventHandler(this.RdoNegative_CheckedChanged);
            // 
            // RdoPositive
            // 
            this.RdoPositive.AutoSize = true;
            this.RdoPositive.Checked = true;
            this.RdoPositive.Location = new System.Drawing.Point(10, 16);
            this.RdoPositive.Margin = new System.Windows.Forms.Padding(2);
            this.RdoPositive.Name = "RdoPositive";
            this.RdoPositive.Size = new System.Drawing.Size(62, 17);
            this.RdoPositive.TabIndex = 21;
            this.RdoPositive.TabStop = true;
            this.RdoPositive.Text = "Positivo";
            this.RdoPositive.UseVisualStyleBackColor = true;
            this.RdoPositive.CheckedChanged += new System.EventHandler(this.RdoPositive_CheckedChanged);
            // 
            // LblAlarmType
            // 
            this.LblAlarmType.AutoSize = true;
            this.LblAlarmType.Location = new System.Drawing.Point(36, 86);
            this.LblAlarmType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAlarmType.Name = "LblAlarmType";
            this.LblAlarmType.Size = new System.Drawing.Size(80, 13);
            this.LblAlarmType.TabIndex = 20;
            this.LblAlarmType.Text = "Tipo de alarma:";
            // 
            // CboEntity
            // 
            this.CboEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEntity.FormattingEnabled = true;
            this.CboEntity.Location = new System.Drawing.Point(39, 38);
            this.CboEntity.Margin = new System.Windows.Forms.Padding(2);
            this.CboEntity.Name = "CboEntity";
            this.CboEntity.Size = new System.Drawing.Size(301, 21);
            this.CboEntity.TabIndex = 19;
            // 
            // LblEntity
            // 
            this.LblEntity.AutoSize = true;
            this.LblEntity.Location = new System.Drawing.Point(36, 12);
            this.LblEntity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEntity.Name = "LblEntity";
            this.LblEntity.Size = new System.Drawing.Size(46, 13);
            this.LblEntity.TabIndex = 18;
            this.LblEntity.Text = "Entidad:";
            // 
            // LblErrorMassage
            // 
            this.LblErrorMassage.AutoSize = true;
            this.LblErrorMassage.Location = new System.Drawing.Point(36, 278);
            this.LblErrorMassage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMassage.Name = "LblErrorMassage";
            this.LblErrorMassage.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMassage.TabIndex = 30;
            // 
            // PnlAlarmType
            // 
            this.PnlAlarmType.Controls.Add(this.RdoNegative);
            this.PnlAlarmType.Controls.Add(this.RdoPositive);
            this.PnlAlarmType.Location = new System.Drawing.Point(39, 102);
            this.PnlAlarmType.Name = "PnlAlarmType";
            this.PnlAlarmType.Size = new System.Drawing.Size(251, 46);
            this.PnlAlarmType.TabIndex = 31;
            // 
            // AlarmConfigurationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlAlarmType);
            this.Controls.Add(this.LblErrorMassage);
            this.Controls.Add(this.TxtPostsAmount);
            this.Controls.Add(this.TxtTimeFrame);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.RdoHours);
            this.Controls.Add(this.RdoDays);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblPosts);
            this.Controls.Add(this.LblAlarmType);
            this.Controls.Add(this.CboEntity);
            this.Controls.Add(this.LblEntity);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AlarmConfigurationUserControl";
            this.Size = new System.Drawing.Size(532, 309);
            this.Load += new System.EventHandler(this.AlarmConfigurationUserControl_Load);
            this.PnlAlarmType.ResumeLayout(false);
            this.PnlAlarmType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPostsAmount;
        private System.Windows.Forms.TextBox TxtTimeFrame;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton RdoHours;
        private System.Windows.Forms.RadioButton RdoDays;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblPosts;
        private System.Windows.Forms.RadioButton RdoNegative;
        private System.Windows.Forms.RadioButton RdoPositive;
        private System.Windows.Forms.Label LblAlarmType;
        private System.Windows.Forms.ComboBox CboEntity;
        private System.Windows.Forms.Label LblEntity;
        private System.Windows.Forms.Label LblErrorMassage;
        private System.Windows.Forms.Panel PnlAlarmType;
    }
}
