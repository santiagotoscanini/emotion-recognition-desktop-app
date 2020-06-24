using System.Windows.Forms;

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
            this.BtnAccept = new System.Windows.Forms.Button();
            this.LblErrorMessageEmptyData = new System.Windows.Forms.Label();
            this.DtpTime = new System.Windows.Forms.DateTimePicker();
            this.DtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.LblSucessful = new System.Windows.Forms.Label();
            this.LbxAuthors = new System.Windows.Forms.ListBox();
            this.LblNoAuthorError = new System.Windows.Forms.Label();
            this.LblNoAuthors = new System.Windows.Forms.Label();
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
            this.LblPhrase.Location = new System.Drawing.Point(84, 49);
            this.LblPhrase.Name = "LblPhrase";
            this.LblPhrase.Size = new System.Drawing.Size(54, 20);
            this.LblPhrase.TabIndex = 1;
            this.LblPhrase.Text = "Frase:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(84, 158);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(58, 20);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Fecha:";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(84, 271);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(48, 20);
            this.LblHour.TabIndex = 3;
            this.LblHour.Text = "Hora:";
            // 
            // TxtPhrase
            // 
            this.TxtPhrase.Location = new System.Drawing.Point(87, 83);
            this.TxtPhrase.Name = "TxtPhrase";
            this.TxtPhrase.Size = new System.Drawing.Size(532, 26);
            this.TxtPhrase.TabIndex = 0;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(327, 406);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(96, 43);
            this.BtnAccept.TabIndex = 3;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(86, 123);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 20);
            this.LblErrorMessageEmptyData.TabIndex = 8;
            // 
            // DtpTime
            // 
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTime.Location = new System.Drawing.Point(87, 309);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.ShowUpDown = true;
            this.DtpTime.Size = new System.Drawing.Size(258, 26);
            this.DtpTime.TabIndex = 2;
            // 
            // DtpCalendar
            // 
            this.DtpCalendar.Location = new System.Drawing.Point(87, 197);
            this.DtpCalendar.Name = "DtpCalendar";
            this.DtpCalendar.Size = new System.Drawing.Size(224, 26);
            this.DtpCalendar.TabIndex = 1;
            // 
            // LblSucessful
            // 
            this.LblSucessful.AutoSize = true;
            this.LblSucessful.BackColor = System.Drawing.Color.Transparent;
            this.LblSucessful.ForeColor = System.Drawing.Color.Green;
            this.LblSucessful.Location = new System.Drawing.Point(430, 417);
            this.LblSucessful.Name = "LblSucessful";
            this.LblSucessful.Size = new System.Drawing.Size(0, 20);
            this.LblSucessful.TabIndex = 11;
            // 
            // LbxAuthors
            // 
            this.LbxAuthors.FormattingEnabled = true;
            this.LbxAuthors.ItemHeight = 20;
            this.LbxAuthors.Location = new System.Drawing.Point(447, 123);
            this.LbxAuthors.Name = "LbxAuthors";
            this.LbxAuthors.Size = new System.Drawing.Size(170, 224);
            this.LbxAuthors.TabIndex = 12;
            // 
            // LblNoAuthorError
            // 
            this.LblNoAuthorError.AutoSize = true;
            this.LblNoAuthorError.ForeColor = System.Drawing.Color.Red;
            this.LblNoAuthorError.Location = new System.Drawing.Point(460, 351);
            this.LblNoAuthorError.Name = "LblNoAuthorError";
            this.LblNoAuthorError.Size = new System.Drawing.Size(0, 20);
            this.LblNoAuthorError.TabIndex = 13;
            // 
            // LblNoAuthors
            // 
            this.LblNoAuthors.AutoSize = true;
            this.LblNoAuthors.ForeColor = System.Drawing.Color.Red;
            this.LblNoAuthors.Location = new System.Drawing.Point(450, 351);
            this.LblNoAuthors.Name = "LblNoAuthors";
            this.LblNoAuthors.Size = new System.Drawing.Size(151, 20);
            this.LblNoAuthors.TabIndex = 33;
            this.LblNoAuthors.Text = "Aún no hay autores.";
            this.LblNoAuthors.Visible = false;
            // 
            // NewPhraseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblNoAuthors);
            this.Controls.Add(this.LbxAuthors);
            this.Controls.Add(this.LblSucessful);
            this.Controls.Add(this.DtpCalendar);
            this.Controls.Add(this.DtpTime);
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.LblNoAuthorError);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtPhrase);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblPhrase);
            this.Controls.Add(this.LblNewPhrase);
            this.Name = "NewPhraseUserControl";
            this.Size = new System.Drawing.Size(798, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNewPhrase;
        private System.Windows.Forms.Label LblPhrase;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.TextBox TxtPhrase;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label LblErrorMessageEmptyData;
        private System.Windows.Forms.DateTimePicker DtpTime;
        private DateTimePicker DtpCalendar;
        private Label LblSucessful;
        private ListBox LbxAuthors;
        private Label LblNoAuthorError;
        private Label LblNoAuthors;
    }
}
