namespace emotionRecognition
{
    partial class AddAlarmUserControl
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
            this.components = new System.ComponentModel.Container();
            this.BtnAlarmReport = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PnlAlarm = new System.Windows.Forms.Panel();
            this.BtnAlarmConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAlarmReport
            // 
            this.BtnAlarmReport.Location = new System.Drawing.Point(400, 12);
            this.BtnAlarmReport.Name = "BtnAlarmReport";
            this.BtnAlarmReport.Size = new System.Drawing.Size(145, 44);
            this.BtnAlarmReport.TabIndex = 1;
            this.BtnAlarmReport.Text = "Reporte alarmas";
            this.BtnAlarmReport.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PnlAlarm
            // 
            this.PnlAlarm.Location = new System.Drawing.Point(3, 62);
            this.PnlAlarm.Name = "PnlAlarm";
            this.PnlAlarm.Size = new System.Drawing.Size(798, 476);
            this.PnlAlarm.TabIndex = 2;
            // 
            // BtnAlarmConfig
            // 
            this.BtnAlarmConfig.Location = new System.Drawing.Point(257, 13);
            this.BtnAlarmConfig.Name = "BtnAlarmConfig";
            this.BtnAlarmConfig.Size = new System.Drawing.Size(145, 44);
            this.BtnAlarmConfig.TabIndex = 1;
            this.BtnAlarmConfig.Text = "Configurar alarma";
            this.BtnAlarmConfig.UseVisualStyleBackColor = true;
            // 
            // AddAlarmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAlarmConfig);
            this.Controls.Add(this.PnlAlarm);
            this.Controls.Add(this.BtnAlarmReport);
            this.Name = "AddAlarmUserControl";
            this.Size = new System.Drawing.Size(804, 541);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAlarmReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel PnlAlarm;
        private System.Windows.Forms.Button BtnAlarmConfig;
    }
}
