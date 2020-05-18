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
            this.BtnSafe = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // TxtPostsAmount
            // 
            this.TxtPostsAmount.Location = new System.Drawing.Point(58, 271);
            this.TxtPostsAmount.Name = "TxtPostsAmount";
            this.TxtPostsAmount.Size = new System.Drawing.Size(450, 26);
            this.TxtPostsAmount.TabIndex = 29;
            // 
            // TxtTimeFrame
            // 
            this.TxtTimeFrame.Location = new System.Drawing.Point(58, 385);
            this.TxtTimeFrame.Name = "TxtTimeFrame";
            this.TxtTimeFrame.Size = new System.Drawing.Size(216, 26);
            this.TxtTimeFrame.TabIndex = 28;
            // 
            // BtnSafe
            // 
            this.BtnSafe.Location = new System.Drawing.Point(651, 416);
            this.BtnSafe.Name = "BtnSafe";
            this.BtnSafe.Size = new System.Drawing.Size(107, 45);
            this.BtnSafe.TabIndex = 27;
            this.BtnSafe.Text = "Guardar";
            this.BtnSafe.UseVisualStyleBackColor = true;
            this.BtnSafe.Click += new System.EventHandler(this.BtnSafe_Click);
            // 
            // RdoHours
            // 
            this.RdoHours.AutoSize = true;
            this.RdoHours.Location = new System.Drawing.Point(431, 385);
            this.RdoHours.Name = "RdoHours";
            this.RdoHours.Size = new System.Drawing.Size(77, 24);
            this.RdoHours.TabIndex = 26;
            this.RdoHours.TabStop = true;
            this.RdoHours.Text = "Horas";
            this.RdoHours.UseVisualStyleBackColor = true;
            // 
            // RdoDays
            // 
            this.RdoDays.AutoSize = true;
            this.RdoDays.Location = new System.Drawing.Point(318, 387);
            this.RdoDays.Name = "RdoDays";
            this.RdoDays.Size = new System.Drawing.Size(66, 24);
            this.RdoDays.TabIndex = 25;
            this.RdoDays.TabStop = true;
            this.RdoDays.Text = "Dias";
            this.RdoDays.UseVisualStyleBackColor = true;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(54, 345);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(126, 20);
            this.LblTime.TabIndex = 24;
            this.LblTime.Text = "Plazo de tiempo:";
            // 
            // LblPosts
            // 
            this.LblPosts.AutoSize = true;
            this.LblPosts.Location = new System.Drawing.Point(54, 233);
            this.LblPosts.Name = "LblPosts";
            this.LblPosts.Size = new System.Drawing.Size(245, 20);
            this.LblPosts.TabIndex = 23;
            this.LblPosts.Text = "Cantidad de posts para activarse:";
            // 
            // RdoNegative
            // 
            this.RdoNegative.AutoSize = true;
            this.RdoNegative.Location = new System.Drawing.Point(220, 170);
            this.RdoNegative.Name = "RdoNegative";
            this.RdoNegative.Size = new System.Drawing.Size(96, 24);
            this.RdoNegative.TabIndex = 22;
            this.RdoNegative.TabStop = true;
            this.RdoNegative.Text = "Negativo";
            this.RdoNegative.UseVisualStyleBackColor = true;
            // 
            // RdoPositive
            // 
            this.RdoPositive.AutoSize = true;
            this.RdoPositive.Location = new System.Drawing.Point(58, 170);
            this.RdoPositive.Name = "RdoPositive";
            this.RdoPositive.Size = new System.Drawing.Size(88, 24);
            this.RdoPositive.TabIndex = 21;
            this.RdoPositive.TabStop = true;
            this.RdoPositive.Text = "Positivo";
            this.RdoPositive.UseVisualStyleBackColor = true;
            // 
            // LblAlarmType
            // 
            this.LblAlarmType.AutoSize = true;
            this.LblAlarmType.Location = new System.Drawing.Point(54, 133);
            this.LblAlarmType.Name = "LblAlarmType";
            this.LblAlarmType.Size = new System.Drawing.Size(117, 20);
            this.LblAlarmType.TabIndex = 20;
            this.LblAlarmType.Text = "Tipo de alarma:";
            // 
            // CboEntity
            // 
            this.CboEntity.FormattingEnabled = true;
            this.CboEntity.Location = new System.Drawing.Point(58, 58);
            this.CboEntity.Name = "CboEntity";
            this.CboEntity.Size = new System.Drawing.Size(450, 28);
            this.CboEntity.TabIndex = 19;
            // 
            // LblEntity
            // 
            this.LblEntity.AutoSize = true;
            this.LblEntity.Location = new System.Drawing.Point(54, 18);
            this.LblEntity.Name = "LblEntity";
            this.LblEntity.Size = new System.Drawing.Size(68, 20);
            this.LblEntity.TabIndex = 18;
            this.LblEntity.Text = "Entidad:";
            // 
            // LblErrorMassage
            // 
            this.LblErrorMassage.AutoSize = true;
            this.LblErrorMassage.Location = new System.Drawing.Point(54, 428);
            this.LblErrorMassage.Name = "LblErrorMassage";
            this.LblErrorMassage.Size = new System.Drawing.Size(0, 20);
            this.LblErrorMassage.TabIndex = 30;
            // 
            // AlarmConfigurationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMassage);
            this.Controls.Add(this.TxtPostsAmount);
            this.Controls.Add(this.TxtTimeFrame);
            this.Controls.Add(this.BtnSafe);
            this.Controls.Add(this.RdoHours);
            this.Controls.Add(this.RdoDays);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblPosts);
            this.Controls.Add(this.RdoNegative);
            this.Controls.Add(this.RdoPositive);
            this.Controls.Add(this.LblAlarmType);
            this.Controls.Add(this.CboEntity);
            this.Controls.Add(this.LblEntity);
            this.Name = "AlarmConfigurationUserControl";
            this.Size = new System.Drawing.Size(798, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPostsAmount;
        private System.Windows.Forms.TextBox TxtTimeFrame;
        private System.Windows.Forms.Button BtnSafe;
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
    }
}
