namespace UserInterface
{
    partial class PhraseReportUserControl
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
            this.LblRegisterPhrase = new System.Windows.Forms.Label();
            this.LstPhrases = new System.Windows.Forms.ListBox();
            this.LblErrorMessageEmptyList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRegisterPhrase
            // 
            this.LblRegisterPhrase.AutoSize = true;
            this.LblRegisterPhrase.Location = new System.Drawing.Point(80, 23);
            this.LblRegisterPhrase.Name = "LblRegisterPhrase";
            this.LblRegisterPhrase.Size = new System.Drawing.Size(145, 20);
            this.LblRegisterPhrase.TabIndex = 0;
            this.LblRegisterPhrase.Text = "Frases registradas:";
            // 
            // LstPhrases
            // 
            this.LstPhrases.FormattingEnabled = true;
            this.LstPhrases.ItemHeight = 20;
            this.LstPhrases.Location = new System.Drawing.Point(84, 66);
            this.LstPhrases.Name = "LstPhrases";
            this.LstPhrases.Size = new System.Drawing.Size(613, 364);
            this.LstPhrases.TabIndex = 1;
            // 
            // LblErrorMessageEmptyList
            // 
            this.LblErrorMessageEmptyList.AutoSize = true;
            this.LblErrorMessageEmptyList.Location = new System.Drawing.Point(342, 212);
            this.LblErrorMessageEmptyList.Name = "LblErrorMessageEmptyList";
            this.LblErrorMessageEmptyList.Size = new System.Drawing.Size(0, 20);
            this.LblErrorMessageEmptyList.TabIndex = 2;
            // 
            // PhraseReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMessageEmptyList);
            this.Controls.Add(this.LstPhrases);
            this.Controls.Add(this.LblRegisterPhrase);
            this.Name = "PhraseReportUserControl";
            this.Size = new System.Drawing.Size(798, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegisterPhrase;
        private System.Windows.Forms.ListBox LstPhrases;
        private System.Windows.Forms.Label LblErrorMessageEmptyList;
    }
}
