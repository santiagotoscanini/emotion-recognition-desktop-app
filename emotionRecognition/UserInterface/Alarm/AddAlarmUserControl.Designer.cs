namespace UserInterface
{
    partial class AddAlarmUserControl
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.RdoHours = new System.Windows.Forms.RadioButton();
            this.RdoDays = new System.Windows.Forms.RadioButton();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblPosts = new System.Windows.Forms.Label();
            this.RdoNegative = new System.Windows.Forms.RadioButton();
            this.RdoPositive = new System.Windows.Forms.RadioButton();
            this.LblAlarmSentiment = new System.Windows.Forms.Label();
            this.CboEntity = new System.Windows.Forms.ComboBox();
            this.LblDoneMessage = new System.Windows.Forms.Label();
            this.LblNoEntities = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudPostQuantity = new System.Windows.Forms.NumericUpDown();
            this.NudTimeLapse = new System.Windows.Forms.NumericUpDown();
            this.RdoAlarmEntities = new System.Windows.Forms.RadioButton();
            this.RdoAlarmAutores = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblAlarmEntity = new System.Windows.Forms.Label();
            this.LblAlarmType = new System.Windows.Forms.Label();
            this.s.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPostQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimeLapse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(651, 415);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 45);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // RdoHours
            // 
            this.RdoHours.AutoSize = true;
            this.RdoHours.Location = new System.Drawing.Point(150, 22);
            this.RdoHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoHours.Name = "RdoHours";
            this.RdoHours.Size = new System.Drawing.Size(77, 24);
            this.RdoHours.TabIndex = 1;
            this.RdoHours.TabStop = true;
            this.RdoHours.Text = "Horas";
            this.RdoHours.UseVisualStyleBackColor = true;
            // 
            // RdoDays
            // 
            this.RdoDays.AutoSize = true;
            this.RdoDays.Checked = true;
            this.RdoDays.Location = new System.Drawing.Point(32, 22);
            this.RdoDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoDays.Name = "RdoDays";
            this.RdoDays.Size = new System.Drawing.Size(66, 24);
            this.RdoDays.TabIndex = 0;
            this.RdoDays.TabStop = true;
            this.RdoDays.Text = "Dias";
            this.RdoDays.UseVisualStyleBackColor = true;
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(54, 350);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(126, 20);
            this.LblTime.TabIndex = 8;
            this.LblTime.Text = "Plazo de tiempo:";
            // 
            // LblPosts
            // 
            this.LblPosts.AutoSize = true;
            this.LblPosts.Location = new System.Drawing.Point(54, 283);
            this.LblPosts.Name = "LblPosts";
            this.LblPosts.Size = new System.Drawing.Size(245, 20);
            this.LblPosts.TabIndex = 23;
            this.LblPosts.Text = "Cantidad de posts para activarse:";
            // 
            // RdoNegative
            // 
            this.RdoNegative.AutoSize = true;
            this.RdoNegative.Location = new System.Drawing.Point(177, 22);
            this.RdoNegative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoNegative.Name = "RdoNegative";
            this.RdoNegative.Size = new System.Drawing.Size(96, 24);
            this.RdoNegative.TabIndex = 1;
            this.RdoNegative.TabStop = true;
            this.RdoNegative.Text = "Negativo";
            this.RdoNegative.UseVisualStyleBackColor = true;
            // 
            // RdoPositive
            // 
            this.RdoPositive.AutoSize = true;
            this.RdoPositive.Checked = true;
            this.RdoPositive.Location = new System.Drawing.Point(22, 22);
            this.RdoPositive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RdoPositive.Name = "RdoPositive";
            this.RdoPositive.Size = new System.Drawing.Size(88, 24);
            this.RdoPositive.TabIndex = 0;
            this.RdoPositive.TabStop = true;
            this.RdoPositive.Text = "Positivo";
            this.RdoPositive.UseVisualStyleBackColor = true;
            // 
            // LblAlarmSentiment
            // 
            this.LblAlarmSentiment.AutoSize = true;
            this.LblAlarmSentiment.Location = new System.Drawing.Point(54, 180);
            this.LblAlarmSentiment.Name = "LblAlarmSentiment";
            this.LblAlarmSentiment.Size = new System.Drawing.Size(174, 20);
            this.LblAlarmSentiment.TabIndex = 20;
            this.LblAlarmSentiment.Text = "Sentimiento a detectar:";
            // 
            // CboEntity
            // 
            this.CboEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEntity.FormattingEnabled = true;
            this.CboEntity.Location = new System.Drawing.Point(58, 137);
            this.CboEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboEntity.Name = "CboEntity";
            this.CboEntity.Size = new System.Drawing.Size(450, 28);
            this.CboEntity.TabIndex = 0;
            // 
            // LblDoneMessage
            // 
            this.LblDoneMessage.AutoSize = true;
            this.LblDoneMessage.ForeColor = System.Drawing.Color.Green;
            this.LblDoneMessage.Location = new System.Drawing.Point(54, 428);
            this.LblDoneMessage.Name = "LblDoneMessage";
            this.LblDoneMessage.Size = new System.Drawing.Size(230, 20);
            this.LblDoneMessage.TabIndex = 30;
            this.LblDoneMessage.Text = "Alarma agregada exitosamente";
            this.LblDoneMessage.Visible = false;
            // 
            // LblNoEntities
            // 
            this.LblNoEntities.AutoSize = true;
            this.LblNoEntities.ForeColor = System.Drawing.Color.Red;
            this.LblNoEntities.Location = new System.Drawing.Point(530, 141);
            this.LblNoEntities.Name = "LblNoEntities";
            this.LblNoEntities.Size = new System.Drawing.Size(167, 20);
            this.LblNoEntities.TabIndex = 32;
            this.LblNoEntities.Text = "Aún no hay entidades.";
            this.LblNoEntities.Visible = false;
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessage.Location = new System.Drawing.Point(326, 353);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(371, 20);
            this.LblErrorMessage.TabIndex = 7;
            this.LblErrorMessage.Text = "La cantidad de posts y plazo debe de ser mayor a 0";
            this.LblErrorMessage.Visible = false;
            // 
            // s
            // 
            this.s.Controls.Add(this.RdoNegative);
            this.s.Controls.Add(this.RdoPositive);
            this.s.Location = new System.Drawing.Point(57, 205);
            this.s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.s.Size = new System.Drawing.Size(292, 62);
            this.s.TabIndex = 1;
            this.s.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoDays);
            this.groupBox1.Controls.Add(this.RdoHours);
            this.groupBox1.Location = new System.Drawing.Point(315, 385);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(244, 62);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // NudPostQuantity
            // 
            this.NudPostQuantity.Location = new System.Drawing.Point(58, 316);
            this.NudPostQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NudPostQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudPostQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPostQuantity.Name = "NudPostQuantity";
            this.NudPostQuantity.Size = new System.Drawing.Size(243, 26);
            this.NudPostQuantity.TabIndex = 33;
            this.NudPostQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudTimeLapse
            // 
            this.NudTimeLapse.Location = new System.Drawing.Point(57, 386);
            this.NudTimeLapse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NudTimeLapse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudTimeLapse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudTimeLapse.Name = "NudTimeLapse";
            this.NudTimeLapse.Size = new System.Drawing.Size(244, 26);
            this.NudTimeLapse.TabIndex = 34;
            this.NudTimeLapse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RdoAlarmEntities
            // 
            this.RdoAlarmEntities.AutoSize = true;
            this.RdoAlarmEntities.Checked = true;
            this.RdoAlarmEntities.Location = new System.Drawing.Point(7, 26);
            this.RdoAlarmEntities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdoAlarmEntities.Name = "RdoAlarmEntities";
            this.RdoAlarmEntities.Size = new System.Drawing.Size(160, 24);
            this.RdoAlarmEntities.TabIndex = 35;
            this.RdoAlarmEntities.TabStop = true;
            this.RdoAlarmEntities.Text = "Alarma Entidades";
            this.RdoAlarmEntities.UseVisualStyleBackColor = true;
            this.RdoAlarmEntities.CheckedChanged += new System.EventHandler(this.RdoAlarmEntities_CheckedChanged);
            // 
            // RdoAlarmAutores
            // 
            this.RdoAlarmAutores.AutoSize = true;
            this.RdoAlarmAutores.Location = new System.Drawing.Point(171, 26);
            this.RdoAlarmAutores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdoAlarmAutores.Name = "RdoAlarmAutores";
            this.RdoAlarmAutores.Size = new System.Drawing.Size(144, 24);
            this.RdoAlarmAutores.TabIndex = 36;
            this.RdoAlarmAutores.TabStop = true;
            this.RdoAlarmAutores.Text = "Alarma Autores";
            this.RdoAlarmAutores.UseVisualStyleBackColor = true;
            this.RdoAlarmAutores.CheckedChanged += new System.EventHandler(this.RdoAlarmAutores_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoAlarmAutores);
            this.groupBox2.Controls.Add(this.RdoAlarmEntities);
            this.groupBox2.Location = new System.Drawing.Point(57, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(328, 66);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // LblAlarmEntity
            // 
            this.LblAlarmEntity.AutoSize = true;
            this.LblAlarmEntity.BackColor = System.Drawing.Color.Transparent;
            this.LblAlarmEntity.Location = new System.Drawing.Point(60, 105);
            this.LblAlarmEntity.Name = "LblAlarmEntity";
            this.LblAlarmEntity.Size = new System.Drawing.Size(68, 20);
            this.LblAlarmEntity.TabIndex = 38;
            this.LblAlarmEntity.Text = "Entidad:";
            // 
            // LblAlarmType
            // 
            this.LblAlarmType.AutoSize = true;
            this.LblAlarmType.Location = new System.Drawing.Point(61, 11);
            this.LblAlarmType.Name = "LblAlarmType";
            this.LblAlarmType.Size = new System.Drawing.Size(117, 20);
            this.LblAlarmType.TabIndex = 39;
            this.LblAlarmType.Text = "Tipo de alarma:";
            // 
            // AddAlarmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblAlarmType);
            this.Controls.Add(this.LblAlarmEntity);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NudTimeLapse);
            this.Controls.Add(this.NudPostQuantity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.LblNoEntities);
            this.Controls.Add(this.LblDoneMessage);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblPosts);
            this.Controls.Add(this.LblAlarmSentiment);
            this.Controls.Add(this.CboEntity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAlarmUserControl";
            this.Size = new System.Drawing.Size(798, 475);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPostQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTimeLapse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton RdoHours;
        private System.Windows.Forms.RadioButton RdoDays;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblPosts;
        private System.Windows.Forms.RadioButton RdoNegative;
        private System.Windows.Forms.RadioButton RdoPositive;
        private System.Windows.Forms.Label LblAlarmSentiment;
        private System.Windows.Forms.ComboBox CboEntity;
        private System.Windows.Forms.Label LblDoneMessage;
        private System.Windows.Forms.Label LblNoEntities;
        private System.Windows.Forms.Label LblErrorMessage;
        private System.Windows.Forms.GroupBox s;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NudPostQuantity;
        private System.Windows.Forms.NumericUpDown NudTimeLapse;
        private System.Windows.Forms.RadioButton RdoAlarmEntities;
        private System.Windows.Forms.RadioButton RdoAlarmAutores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblAlarmEntity;
        private System.Windows.Forms.Label LblAlarmType;
    }
}
