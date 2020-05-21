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
            this.RbtPositive = new System.Windows.Forms.RadioButton();
            this.RbtNegative = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSentiments
            // 
            this.PnlSentiments.Location = new System.Drawing.Point(3, 50);
            this.PnlSentiments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlSentiments.Name = "PnlSentiments";
            this.PnlSentiments.Size = new System.Drawing.Size(709, 380);
            this.PnlSentiments.TabIndex = 9;
            // 
            // RbtPositive
            // 
            this.RbtPositive.AutoSize = true;
            this.RbtPositive.Checked = true;
            this.RbtPositive.Location = new System.Drawing.Point(6, 15);
            this.RbtPositive.Name = "RbtPositive";
            this.RbtPositive.Size = new System.Drawing.Size(78, 21);
            this.RbtPositive.TabIndex = 10;
            this.RbtPositive.TabStop = true;
            this.RbtPositive.Text = "Positivo";
            this.RbtPositive.UseVisualStyleBackColor = true;
            this.RbtPositive.CheckedChanged += new System.EventHandler(this.RbtPositive_CheckedChanged);
            // 
            // RbtNegative
            // 
            this.RbtNegative.AutoSize = true;
            this.RbtNegative.Location = new System.Drawing.Point(192, 15);
            this.RbtNegative.Name = "RbtNegative";
            this.RbtNegative.Size = new System.Drawing.Size(85, 21);
            this.RbtNegative.TabIndex = 11;
            this.RbtNegative.Text = "Negativo";
            this.RbtNegative.UseVisualStyleBackColor = true;
            this.RbtNegative.CheckedChanged += new System.EventHandler(this.RbtNegative_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.RbtPositive);
            this.groupBox1.Controls.Add(this.RbtNegative);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(190, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // AddSentimentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlSentiments);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSentimentUserControl";
            this.Size = new System.Drawing.Size(715, 433);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSentiments;
        private System.Windows.Forms.RadioButton RbtPositive;
        private System.Windows.Forms.RadioButton RbtNegative;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
