namespace UserInterface
{
    partial class SentimentUserControl
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
            this.LblErrorMessageNotSelectedSentiment = new System.Windows.Forms.Label();
            this.LblErrorMessageEmptyData = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblSentiments = new System.Windows.Forms.Label();
            this.LstSentiments = new System.Windows.Forms.ListBox();
            this.TxtNewSentiment = new System.Windows.Forms.TextBox();
            this.LblRegisterNewSentiment = new System.Windows.Forms.Label();
            this.LblErrorMessageEmptyList = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoNegative = new System.Windows.Forms.RadioButton();
            this.RdoPositive = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblErrorMessageNotSelectedSentiment
            // 
            this.LblErrorMessageNotSelectedSentiment.AutoSize = true;
            this.LblErrorMessageNotSelectedSentiment.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageNotSelectedSentiment.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageNotSelectedSentiment.Location = new System.Drawing.Point(535, 182);
            this.LblErrorMessageNotSelectedSentiment.Name = "LblErrorMessageNotSelectedSentiment";
            this.LblErrorMessageNotSelectedSentiment.Size = new System.Drawing.Size(0, 17);
            this.LblErrorMessageNotSelectedSentiment.TabIndex = 40;
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(73, 73);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 17);
            this.LblErrorMessageEmptyData.TabIndex = 39;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(538, 88);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(79, 33);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(538, 145);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 33);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblSentiments
            // 
            this.LblSentiments.AutoSize = true;
            this.LblSentiments.Location = new System.Drawing.Point(72, 124);
            this.LblSentiments.Name = "LblSentiments";
            this.LblSentiments.Size = new System.Drawing.Size(168, 17);
            this.LblSentiments.TabIndex = 36;
            this.LblSentiments.Text = "Sentimientos registrados:";
            // 
            // LstSentiments
            // 
            this.LstSentiments.FormattingEnabled = true;
            this.LstSentiments.ItemHeight = 16;
            this.LstSentiments.Location = new System.Drawing.Point(76, 153);
            this.LstSentiments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstSentiments.Name = "LstSentiments";
            this.LstSentiments.Size = new System.Drawing.Size(425, 212);
            this.LstSentiments.TabIndex = 2;
            // 
            // TxtNewSentiment
            // 
            this.TxtNewSentiment.Location = new System.Drawing.Point(75, 98);
            this.TxtNewSentiment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtNewSentiment.Name = "TxtNewSentiment";
            this.TxtNewSentiment.Size = new System.Drawing.Size(425, 22);
            this.TxtNewSentiment.TabIndex = 0;
            // 
            // LblRegisterNewSentiment
            // 
            this.LblRegisterNewSentiment.AutoSize = true;
            this.LblRegisterNewSentiment.Location = new System.Drawing.Point(73, 56);
            this.LblRegisterNewSentiment.Name = "LblRegisterNewSentiment";
            this.LblRegisterNewSentiment.Size = new System.Drawing.Size(189, 17);
            this.LblRegisterNewSentiment.TabIndex = 33;
            this.LblRegisterNewSentiment.Text = "Registrar nuevo sentimiento:";
            this.LblRegisterNewSentiment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblErrorMessageEmptyList
            // 
            this.LblErrorMessageEmptyList.AutoSize = true;
            this.LblErrorMessageEmptyList.Location = new System.Drawing.Point(196, 220);
            this.LblErrorMessageEmptyList.Name = "LblErrorMessageEmptyList";
            this.LblErrorMessageEmptyList.Size = new System.Drawing.Size(0, 17);
            this.LblErrorMessageEmptyList.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoNegative);
            this.groupBox2.Controls.Add(this.RdoPositive);
            this.groupBox2.Location = new System.Drawing.Point(76, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 41);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // RdoNegative
            // 
            this.RdoNegative.AutoSize = true;
            this.RdoNegative.Location = new System.Drawing.Point(201, 13);
            this.RdoNegative.Name = "RdoNegative";
            this.RdoNegative.Size = new System.Drawing.Size(85, 21);
            this.RdoNegative.TabIndex = 36;
            this.RdoNegative.TabStop = true;
            this.RdoNegative.Text = "Negativo";
            this.RdoNegative.UseVisualStyleBackColor = true;
            this.RdoNegative.CheckedChanged += new System.EventHandler(this.RdoNegative_CheckedChanged);
            // 
            // RdoPositive
            // 
            this.RdoPositive.AutoSize = true;
            this.RdoPositive.Checked = true;
            this.RdoPositive.Location = new System.Drawing.Point(6, 13);
            this.RdoPositive.Name = "RdoPositive";
            this.RdoPositive.Size = new System.Drawing.Size(85, 21);
            this.RdoPositive.TabIndex = 35;
            this.RdoPositive.TabStop = true;
            this.RdoPositive.Text = "Positivos";
            this.RdoPositive.UseVisualStyleBackColor = true;
            this.RdoPositive.CheckedChanged += new System.EventHandler(this.RdoPositive_CheckedChanged);
            // 
            // PositiveSentimentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblErrorMessageEmptyList);
            this.Controls.Add(this.LblErrorMessageNotSelectedSentiment);
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblSentiments);
            this.Controls.Add(this.LstSentiments);
            this.Controls.Add(this.TxtNewSentiment);
            this.Controls.Add(this.LblRegisterNewSentiment);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PositiveSentimentUserControl";
            this.Size = new System.Drawing.Size(709, 380);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblErrorMessageNotSelectedSentiment;
        private System.Windows.Forms.Label LblErrorMessageEmptyData;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblSentiments;
        private System.Windows.Forms.ListBox LstSentiments;
        private System.Windows.Forms.TextBox TxtNewSentiment;
        private System.Windows.Forms.Label LblRegisterNewSentiment;
        private System.Windows.Forms.Label LblErrorMessageEmptyList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoNegative;
        private System.Windows.Forms.RadioButton RdoPositive;
    }
}
