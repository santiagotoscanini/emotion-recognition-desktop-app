namespace UserInterface
{
    partial class AlarmReportUserControl
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
            this.LblAlarms = new System.Windows.Forms.Label();
            this.GrdAlarms = new System.Windows.Forms.DataGridView();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentimentToDetect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSentimentsNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAlarms
            // 
            this.LblAlarms.AutoSize = true;
            this.LblAlarms.Location = new System.Drawing.Point(26, 13);
            this.LblAlarms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAlarms.Name = "LblAlarms";
            this.LblAlarms.Size = new System.Drawing.Size(100, 13);
            this.LblAlarms.TabIndex = 1;
            this.LblAlarms.Text = "Alarmas generadas:";
            // 
            // GrdAlarms
            // 
            this.GrdAlarms.AllowUserToAddRows = false;
            this.GrdAlarms.AllowUserToDeleteRows = false;
            this.GrdAlarms.AllowUserToOrderColumns = true;
            this.GrdAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Entidad,
            this.SearchType,
            this.Time,
            this.SentimentToDetect,
            this.NumberOfSentimentsNeeded,
            this.IsActivated});
            this.GrdAlarms.Location = new System.Drawing.Point(14, 46);
            this.GrdAlarms.Name = "GrdAlarms";
            this.GrdAlarms.ReadOnly = true;
            this.GrdAlarms.RowHeadersVisible = false;
            this.GrdAlarms.Size = new System.Drawing.Size(503, 206);
            this.GrdAlarms.TabIndex = 2;
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidadas";
            this.Entidad.Name = "Entidad";
            this.Entidad.ReadOnly = true;
            // 
            // SearchType
            // 
            this.SearchType.HeaderText = "Tipo de busqueda";
            this.SearchType.Name = "SearchType";
            this.SearchType.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Tiempo";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // SentimentToDetect
            // 
            this.SentimentToDetect.HeaderText = "Sentimiento a detectar";
            this.SentimentToDetect.Name = "SentimentToDetect";
            this.SentimentToDetect.ReadOnly = true;
            // 
            // NumberOfSentimentsNeeded
            // 
            this.NumberOfSentimentsNeeded.HeaderText = "Cantidad de sentimientos";
            this.NumberOfSentimentsNeeded.Name = "NumberOfSentimentsNeeded";
            this.NumberOfSentimentsNeeded.ReadOnly = true;
            // 
            // IsActivated
            // 
            this.IsActivated.HeaderText = "Activada";
            this.IsActivated.Name = "IsActivated";
            this.IsActivated.ReadOnly = true;
            // 
            // AlarmReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdAlarms);
            this.Controls.Add(this.LblAlarms);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlarmReportUserControl";
            this.Size = new System.Drawing.Size(532, 309);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAlarms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblAlarms;
        private System.Windows.Forms.DataGridView GrdAlarms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SearchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentimentToDetect;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSentimentsNeeded;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActivated;
    }
}
