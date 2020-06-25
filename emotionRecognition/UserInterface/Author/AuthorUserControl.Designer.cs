namespace UserInterface
{
    partial class AuthorUserControl
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
            this.BtnAuthorAdd = new System.Windows.Forms.Button();
            this.PnlAlarm = new System.Windows.Forms.Panel();
            this.BtnAuthorReport = new System.Windows.Forms.Button();
            this.BtnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAuthorAdd
            // 
            this.BtnAuthorAdd.Location = new System.Drawing.Point(151, 0);
            this.BtnAuthorAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAuthorAdd.Name = "BtnAuthorAdd";
            this.BtnAuthorAdd.Size = new System.Drawing.Size(129, 36);
            this.BtnAuthorAdd.TabIndex = 3;
            this.BtnAuthorAdd.Text = "Agregar autor";
            this.BtnAuthorAdd.UseVisualStyleBackColor = true;
            this.BtnAuthorAdd.Click += new System.EventHandler(this.BtnAuthorAdd_Click);
            // 
            // PnlAlarm
            // 
            this.PnlAlarm.Location = new System.Drawing.Point(3, 51);
            this.PnlAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlAlarm.Name = "PnlAlarm";
            this.PnlAlarm.Size = new System.Drawing.Size(709, 380);
            this.PnlAlarm.TabIndex = 5;
            // 
            // BtnAuthorReport
            // 
            this.BtnAuthorReport.Location = new System.Drawing.Point(286, -1);
            this.BtnAuthorReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAuthorReport.Name = "BtnAuthorReport";
            this.BtnAuthorReport.Size = new System.Drawing.Size(129, 36);
            this.BtnAuthorReport.TabIndex = 4;
            this.BtnAuthorReport.Text = "Reporte autores";
            this.BtnAuthorReport.UseVisualStyleBackColor = true;
            this.BtnAuthorReport.Click += new System.EventHandler(this.BtnAuthorReport_Click);
            // 
            // BtnStatistics
            // 
            this.BtnStatistics.Location = new System.Drawing.Point(421, -1);
            this.BtnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStatistics.Name = "BtnStatistics";
            this.BtnStatistics.Size = new System.Drawing.Size(147, 36);
            this.BtnStatistics.TabIndex = 6;
            this.BtnStatistics.Text = "Estadisticas autores";
            this.BtnStatistics.UseVisualStyleBackColor = true;
            this.BtnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // AuthorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnStatistics);
            this.Controls.Add(this.BtnAuthorAdd);
            this.Controls.Add(this.PnlAlarm);
            this.Controls.Add(this.BtnAuthorReport);
            this.Name = "AuthorUserControl";
            this.Size = new System.Drawing.Size(715, 433);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAuthorAdd;
        private System.Windows.Forms.Panel PnlAlarm;
        private System.Windows.Forms.Button BtnAuthorReport;
        private System.Windows.Forms.Button BtnStatistics;
    }
}
