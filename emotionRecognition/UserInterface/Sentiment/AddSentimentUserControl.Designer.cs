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
            this.BtnPositive = new System.Windows.Forms.Button();
            this.BtnNegative = new System.Windows.Forms.Button();
            this.PnlSentiments = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnPositive
            // 
            this.BtnPositive.Location = new System.Drawing.Point(147, 12);
            this.BtnPositive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPositive.Name = "BtnPositive";
            this.BtnPositive.Size = new System.Drawing.Size(97, 29);
            this.BtnPositive.TabIndex = 7;
            this.BtnPositive.Text = "Positivos";
            this.BtnPositive.UseVisualStyleBackColor = true;
            this.BtnPositive.Click += new System.EventHandler(this.BtnPositive_Click);
            // 
            // BtnNegative
            // 
            this.BtnNegative.Location = new System.Drawing.Point(286, 12);
            this.BtnNegative.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnNegative.Name = "BtnNegative";
            this.BtnNegative.Size = new System.Drawing.Size(97, 29);
            this.BtnNegative.TabIndex = 8;
            this.BtnNegative.Text = "Negativos";
            this.BtnNegative.UseVisualStyleBackColor = true;
            this.BtnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            // 
            // PnlSentiments
            // 
            this.PnlSentiments.Location = new System.Drawing.Point(2, 41);
            this.PnlSentiments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlSentiments.Name = "PnlSentiments";
            this.PnlSentiments.Size = new System.Drawing.Size(532, 309);
            this.PnlSentiments.TabIndex = 9;
            // 
            // AddSentimentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlSentiments);
            this.Controls.Add(this.BtnPositive);
            this.Controls.Add(this.BtnNegative);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddSentimentUserControl";
            this.Size = new System.Drawing.Size(536, 352);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnPositive;
        private System.Windows.Forms.Button BtnNegative;
        private System.Windows.Forms.Panel PnlSentiments;
    }
}
