namespace UserInterface
{
    partial class AuthorStatisticsUserControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ChtStatisticsAuthors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChtStatisticsAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtStatisticsAuthors
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtStatisticsAuthors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtStatisticsAuthors.Legends.Add(legend1);
            this.ChtStatisticsAuthors.Location = new System.Drawing.Point(3, 0);
            this.ChtStatisticsAuthors.Name = "ChtStatisticsAuthors";
            this.ChtStatisticsAuthors.Size = new System.Drawing.Size(703, 377);
            this.ChtStatisticsAuthors.TabIndex = 0;
            this.ChtStatisticsAuthors.Text = "chart1";
            // 
            // AuthorStatisticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChtStatisticsAuthors);
            this.Name = "AuthorStatisticsUserControl";
            this.Size = new System.Drawing.Size(709, 380);
            ((System.ComponentModel.ISupportInitialize)(this.ChtStatisticsAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtStatisticsAuthors;
    }
}
