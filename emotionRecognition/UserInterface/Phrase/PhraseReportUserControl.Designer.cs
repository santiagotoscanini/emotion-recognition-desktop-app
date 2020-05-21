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
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Date,
            this.Entity,
            this.State});
            this.GrdReport.Location = new System.Drawing.Point(62, 43);
            this.GrdReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrdReport.Name = "GrdReport";
            this.GrdReport.ReadOnly = true;
            this.GrdReport.RowHeadersVisible = false;
            this.GrdReport.RowHeadersWidth = 51;
            this.GrdReport.RowTemplate.Height = 24;
            this.GrdReport.Size = new System.Drawing.Size(415, 245);
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
            // PhraseReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhraseReportUserControl";
            this.Size = new System.Drawing.Size(532, 310);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phrase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Label LblNoPhrases;
    }
}
