namespace UserInterface
{
    partial class NewPhraseUserControl
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
            this.LblNewPhrase = new System.Windows.Forms.Label();
            this.LblPhrase = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.TxtPhrase = new System.Windows.Forms.TextBox();
            this.CalPhraseDate = new System.Windows.Forms.MonthCalendar();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.LblErrorMessageEmptyData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNewPhrase
            // 
            this.LblNewPhrase.AutoSize = true;
            this.LblNewPhrase.Location = new System.Drawing.Point(297, 23);
            this.LblNewPhrase.Name = "LblNewPhrase";
            this.LblNewPhrase.Size = new System.Drawing.Size(161, 20);
            this.LblNewPhrase.TabIndex = 0;
            this.LblNewPhrase.Text = "Registrar nueva frase";
            // 
            // LblPhrase
            // 
            this.LblPhrase.AutoSize = true;
            this.LblPhrase.Location = new System.Drawing.Point(83, 50);
            this.LblPhrase.Name = "LblPhrase";
            this.LblPhrase.Size = new System.Drawing.Size(54, 20);
            this.LblPhrase.TabIndex = 1;
            this.LblPhrase.Text = "Frase:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(83, 159);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(58, 20);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Fecha:";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(420, 159);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(48, 20);
            this.LblHour.TabIndex = 3;
            this.LblHour.Text = "Hora:";
            // 
            // TxtPhrase
            // 
            this.TxtPhrase.Location = new System.Drawing.Point(87, 84);
            this.TxtPhrase.Name = "TxtPhrase";
            this.TxtPhrase.Size = new System.Drawing.Size(532, 26);
            this.TxtPhrase.TabIndex = 4;
            // 
            // CalPhraseDate
            // 
            this.CalPhraseDate.Location = new System.Drawing.Point(87, 197);
            this.CalPhraseDate.Name = "CalPhraseDate";
            this.CalPhraseDate.TabIndex = 6;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(676, 407);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(97, 43);
            this.BtnAccept.TabIndex = 7;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(86, 122);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 20);
            this.LblErrorMessageEmptyData.TabIndex = 8;
            // 
            // NewPhraseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.CalPhraseDate);
            this.Controls.Add(this.TxtPhrase);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblPhrase);
            this.Controls.Add(this.LblNewPhrase);
            this.Name = "NewPhraseUserControl";
            this.Size = new System.Drawing.Size(798, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNewPhrase;
        private System.Windows.Forms.Label LblPhrase;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.TextBox TxtPhrase;
        private System.Windows.Forms.MonthCalendar CalPhraseDate;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label LblErrorMessageEmptyData;
    }
}
