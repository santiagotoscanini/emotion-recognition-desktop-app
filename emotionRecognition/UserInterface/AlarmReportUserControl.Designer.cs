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
            this.LstAlarms = new System.Windows.Forms.ListBox();
            this.LblAlarms = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstAlarms
            // 
            this.LstAlarms.FormattingEnabled = true;
            this.LstAlarms.ItemHeight = 20;
            this.LstAlarms.Location = new System.Drawing.Point(43, 68);
            this.LstAlarms.Name = "LstAlarms";
            this.LstAlarms.Size = new System.Drawing.Size(703, 364);
            this.LstAlarms.TabIndex = 0;
            // 
            // LblAlarms
            // 
            this.LblAlarms.AutoSize = true;
            this.LblAlarms.Location = new System.Drawing.Point(39, 20);
            this.LblAlarms.Name = "LblAlarms";
            this.LblAlarms.Size = new System.Drawing.Size(151, 20);
            this.LblAlarms.TabIndex = 1;
            this.LblAlarms.Text = "Alarmas generadas:";
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.Location = new System.Drawing.Point(371, 229);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.LblErrorMessage.TabIndex = 2;
            // 
            // AlarmReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.LblAlarms);
            this.Controls.Add(this.LstAlarms);
            this.Name = "AlarmReportUserControl";
            this.Size = new System.Drawing.Size(798, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstAlarms;
        private System.Windows.Forms.Label LblAlarms;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}
