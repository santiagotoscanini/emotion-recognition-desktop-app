namespace emotionRecognition
{
    partial class AddSentimentUserControl
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
            this.PnlSentiments = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // PnlSentiments
            // 
            this.PnlSentiments.Location = new System.Drawing.Point(3, 2);
            this.PnlSentiments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlSentiments.Name = "PnlSentiments";
            this.PnlSentiments.Size = new System.Drawing.Size(709, 428);
            this.PnlSentiments.TabIndex = 9;
            // 
            // AddSentimentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlSentiments);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSentimentUserControl";
            this.Size = new System.Drawing.Size(715, 433);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSentiments;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
