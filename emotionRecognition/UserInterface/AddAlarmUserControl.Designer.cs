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
            this.BtnAlarmReport.Location = new System.Drawing.Point(267, 8);
            this.BtnAlarmReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAlarmReport.Name = "BtnAlarmReport";
            this.BtnAlarmReport.Size = new System.Drawing.Size(97, 29);
            this.BtnAlarmReport.TabIndex = 1;
            this.BtnAlarmReport.Text = "Reporte alarmas";
            this.BtnAlarmReport.UseVisualStyleBackColor = true;
            this.BtnAlarmReport.Click += new System.EventHandler(this.BtnAlarmReport_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PnlAlarm
            // 
            this.PnlAlarm.Location = new System.Drawing.Point(2, 40);
            this.PnlAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlAlarm.Name = "PnlAlarm";
            this.PnlAlarm.Size = new System.Drawing.Size(532, 309);
            this.PnlAlarm.TabIndex = 2;
            // 
            // BtnAlarmConfig
            // 
            this.BtnAlarmConfig.Location = new System.Drawing.Point(171, 8);
            this.BtnAlarmConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAlarmConfig.Name = "BtnAlarmConfig";
            this.BtnAlarmConfig.Size = new System.Drawing.Size(97, 29);
            this.BtnAlarmConfig.TabIndex = 1;
            this.BtnAlarmConfig.Text = "Configurar alarma";
            this.BtnAlarmConfig.UseVisualStyleBackColor = true;
            this.BtnAlarmConfig.Click += new System.EventHandler(this.AlarmConfigButton_Click);
            // 
            // AddAlarmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAlarmConfig);
            this.Controls.Add(this.PnlAlarm);
            this.Controls.Add(this.BtnAlarmReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddAlarmUserControl";
            this.Size = new System.Drawing.Size(536, 352);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAlarmReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel PnlAlarm;
        private System.Windows.Forms.Button BtnAlarmConfig;
    }
}
