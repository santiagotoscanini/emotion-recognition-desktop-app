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
            this.GrdReport = new System.Windows.Forms.DataGridView();
            this.Phrase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblReportPhraseHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdReport
            // 
            this.GrdReport.AllowUserToAddRows = false;
            this.GrdReport.AllowUserToDeleteRows = false;
            this.GrdReport.AllowUserToOrderColumns = true;
            this.GrdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phrase,
            this.Autor,
            this.Date,
            this.Entity,
            this.State});
            this.GrdReport.Location = new System.Drawing.Point(93, 66);
            this.GrdReport.Name = "GrdReport";
            this.GrdReport.ReadOnly = true;
            this.GrdReport.RowHeadersVisible = false;
            this.GrdReport.RowHeadersWidth = 51;
            this.GrdReport.RowTemplate.Height = 24;
            this.GrdReport.Size = new System.Drawing.Size(622, 377);
            this.GrdReport.TabIndex = 4;
            // 
            // Phrase
            // 
            this.Phrase.HeaderText = "Frase";
            this.Phrase.MinimumWidth = 6;
            this.Phrase.Name = "Phrase";
            this.Phrase.ReadOnly = true;
            this.Phrase.Width = 125;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 8;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Entity
            // 
            this.Entity.HeaderText = "Entidad";
            this.Entity.MinimumWidth = 6;
            this.Entity.Name = "Entity";
            this.Entity.ReadOnly = true;
            this.Entity.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "Estado";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 125;
            // 
            // LblReportPhraseHeader
            // 
            this.LblReportPhraseHeader.AutoSize = true;
            this.LblReportPhraseHeader.Location = new System.Drawing.Point(89, 25);
            this.LblReportPhraseHeader.Name = "LblReportPhraseHeader";
            this.LblReportPhraseHeader.Size = new System.Drawing.Size(58, 20);
            this.LblReportPhraseHeader.TabIndex = 5;
            this.LblReportPhraseHeader.Text = "Frases";
            // 
            // PhraseReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblReportPhraseHeader);
            this.Controls.Add(this.GrdReport);
            this.Name = "PhraseReportUserControl";
            this.Size = new System.Drawing.Size(798, 477);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GrdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Label LblReportPhraseHeader;
    }
}
