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
            this.SuspendLayout();
            // 
            // LblNewPhrase
            // 
            this.LblNewPhrase.AutoSize = true;
            this.LblNewPhrase.Location = new System.Drawing.Point(264, 18);
            this.LblNewPhrase.Name = "LblNewPhrase";
            this.LblNewPhrase.Size = new System.Drawing.Size(145, 17);
            this.LblNewPhrase.TabIndex = 0;
            this.LblNewPhrase.Text = "Registrar nueva frase";
            // 
            // LblPhrase
            // 
            this.LblPhrase.AutoSize = true;
            this.LblPhrase.Location = new System.Drawing.Point(74, 40);
            this.LblPhrase.Name = "LblPhrase";
            this.LblPhrase.Size = new System.Drawing.Size(48, 17);
            this.LblPhrase.TabIndex = 1;
            this.LblPhrase.Text = "Frase:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(74, 127);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(51, 17);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Fecha:";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(74, 216);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(43, 17);
            this.LblHour.TabIndex = 3;
            this.LblHour.Text = "Hora:";
            // 
            // TxtPhrase
            // 
            this.TxtPhrase.Location = new System.Drawing.Point(77, 67);
            this.TxtPhrase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPhrase.Name = "TxtPhrase";
            this.TxtPhrase.Size = new System.Drawing.Size(473, 22);
            this.TxtPhrase.TabIndex = 4;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(291, 325);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(86, 34);
            this.BtnAccept.TabIndex = 7;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(76, 98);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 17);
            this.LblErrorMessageEmptyData.TabIndex = 8;
            // 
            // DtpTime
            // 
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpTime.Location = new System.Drawing.Point(77, 247);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.ShowUpDown = true;
            this.DtpTime.Size = new System.Drawing.Size(229, 22);
            this.DtpTime.TabIndex = 9;
            // 
            // DtpCalendar
            // 
            this.DtpCalendar.Location = new System.Drawing.Point(77, 158);
            this.DtpCalendar.Name = "DtpCalendar";
            this.DtpCalendar.Size = new System.Drawing.Size(200, 22);
            this.DtpCalendar.TabIndex = 10;
            // 
            // LblSucessful
            // 
            this.LblSucessful.AutoSize = true;
            this.LblSucessful.Location = new System.Drawing.Point(383, 325);
            this.LblSucessful.Name = "LblSucessful";
            this.LblSucessful.Size = new System.Drawing.Size(0, 17);
            this.LblSucessful.TabIndex = 11;
            // 
            // NewPhraseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblSucessful);
            this.Controls.Add(this.DtpCalendar);
            this.Controls.Add(this.DtpTime);
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.TxtPhrase);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblPhrase);
            this.Controls.Add(this.LblNewPhrase);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewPhraseUserControl";
            this.Size = new System.Drawing.Size(709, 381);
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
    }
}
