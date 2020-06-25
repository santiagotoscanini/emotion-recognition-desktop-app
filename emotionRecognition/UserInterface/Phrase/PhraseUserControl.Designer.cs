namespace emotionRecognition
{
    partial class AddPhraseUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAddPhrase = new System.Windows.Forms.Button();
            this.PnlPhrases = new System.Windows.Forms.Panel();
            this.BtnPhraseReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddPhrase
            // 
            this.BtnAddPhrase.Location = new System.Drawing.Point(150, 5);
            this.BtnAddPhrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddPhrase.Name = "BtnAddPhrase";
            this.BtnAddPhrase.Size = new System.Drawing.Size(97, 29);
            this.BtnAddPhrase.TabIndex = 3;
            this.BtnAddPhrase.Text = "Registrar Frase";
            this.BtnAddPhrase.UseVisualStyleBackColor = true;
            this.BtnAddPhrase.Click += new System.EventHandler(this.BtnAddPhrase_Click);
            // 
            // PnlPhrases
            // 
            this.PnlPhrases.Location = new System.Drawing.Point(2, 37);
            this.PnlPhrases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlPhrases.Name = "PnlPhrases";
            this.PnlPhrases.Size = new System.Drawing.Size(532, 309);
            this.PnlPhrases.TabIndex = 5;
            // 
            // BtnPhraseReport
            // 
            this.BtnPhraseReport.Location = new System.Drawing.Point(287, 5);
            this.BtnPhraseReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPhraseReport.Name = "BtnPhraseReport";
            this.BtnPhraseReport.Size = new System.Drawing.Size(97, 29);
            this.BtnPhraseReport.TabIndex = 4;
            this.BtnPhraseReport.Text = "Reporte";
            this.BtnPhraseReport.UseVisualStyleBackColor = true;
            this.BtnPhraseReport.Click += new System.EventHandler(this.BtnPhraseReport_Click);
            // 
            // AddPhraseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddPhrase);
            this.Controls.Add(this.PnlPhrases);
            this.Controls.Add(this.BtnPhraseReport);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddPhraseUserControl";
            this.Size = new System.Drawing.Size(536, 352);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddPhrase;
        private System.Windows.Forms.Panel PnlPhrases;
        private System.Windows.Forms.Button BtnPhraseReport;
    }
}
