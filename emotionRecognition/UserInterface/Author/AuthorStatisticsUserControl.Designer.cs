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
            this.RboPositiveSentiment = new System.Windows.Forms.RadioButton();
            this.RboNegativeSentiments = new System.Windows.Forms.RadioButton();
            this.RboNamedEntities = new System.Windows.Forms.RadioButton();
            this.RboPercentagePhrases = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ChtStatisticsAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtStatisticsAuthors
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtStatisticsAuthors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtStatisticsAuthors.Legends.Add(legend1);
            this.ChtStatisticsAuthors.Location = new System.Drawing.Point(0, 93);
            this.ChtStatisticsAuthors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChtStatisticsAuthors.Name = "ChtStatisticsAuthors";
            this.ChtStatisticsAuthors.Size = new System.Drawing.Size(798, 378);
            this.ChtStatisticsAuthors.TabIndex = 0;
            this.ChtStatisticsAuthors.Text = "chart1";
            // 
            // RboPositiveSentiment
            // 
            this.RboPositiveSentiment.AutoSize = true;
            this.RboPositiveSentiment.Location = new System.Drawing.Point(10, 16);
            this.RboPositiveSentiment.Name = "RboPositiveSentiment";
            this.RboPositiveSentiment.Size = new System.Drawing.Size(279, 24);
            this.RboPositiveSentiment.TabIndex = 1;
            this.RboPositiveSentiment.TabStop = true;
            this.RboPositiveSentiment.Text = "Cantidad de sentimientos positivos";
            this.RboPositiveSentiment.UseVisualStyleBackColor = true;
            this.RboPositiveSentiment.CheckedChanged += new System.EventHandler(this.RboPositiveSentiment_CheckedChanged);
            // 
            // RboNegativeSentiments
            // 
            this.RboNegativeSentiments.AutoSize = true;
            this.RboNegativeSentiments.Location = new System.Drawing.Point(10, 46);
            this.RboNegativeSentiments.Name = "RboNegativeSentiments";
            this.RboNegativeSentiments.Size = new System.Drawing.Size(286, 24);
            this.RboNegativeSentiments.TabIndex = 2;
            this.RboNegativeSentiments.TabStop = true;
            this.RboNegativeSentiments.Text = "Cantidad de sentimientos negativos";
            this.RboNegativeSentiments.UseVisualStyleBackColor = true;
            this.RboNegativeSentiments.CheckedChanged += new System.EventHandler(this.RboNegativeSentiments_CheckedChanged);
            // 
            // RboNamedEntities
            // 
            this.RboNamedEntities.AutoSize = true;
            this.RboNamedEntities.Location = new System.Drawing.Point(389, 16);
            this.RboNamedEntities.Name = "RboNamedEntities";
            this.RboNamedEntities.Size = new System.Drawing.Size(293, 24);
            this.RboNamedEntities.TabIndex = 3;
            this.RboNamedEntities.TabStop = true;
            this.RboNamedEntities.Text = "Cantidad de entidades mencionadas";
            this.RboNamedEntities.UseVisualStyleBackColor = true;
            this.RboNamedEntities.CheckedChanged += new System.EventHandler(this.RboNamedEntities_CheckedChanged);
            // 
            // RboPercentagePhrases
            // 
            this.RboPercentagePhrases.AutoSize = true;
            this.RboPercentagePhrases.Location = new System.Drawing.Point(389, 46);
            this.RboPercentagePhrases.Name = "RboPercentagePhrases";
            this.RboPercentagePhrases.Size = new System.Drawing.Size(236, 24);
            this.RboPercentagePhrases.TabIndex = 4;
            this.RboPercentagePhrases.TabStop = true;
            this.RboPercentagePhrases.Text = "Porcentage de frases diarias";
            this.RboPercentagePhrases.UseVisualStyleBackColor = true;
            this.RboPercentagePhrases.CheckedChanged += new System.EventHandler(this.RboPercentagePhrases_CheckedChanged);
            // 
            // AuthorStatisticsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RboPercentagePhrases);
            this.Controls.Add(this.RboNamedEntities);
            this.Controls.Add(this.RboNegativeSentiments);
            this.Controls.Add(this.RboPositiveSentiment);
            this.Controls.Add(this.ChtStatisticsAuthors);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorStatisticsUserControl";
            this.Size = new System.Drawing.Size(798, 475);
            ((System.ComponentModel.ISupportInitialize)(this.ChtStatisticsAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtStatisticsAuthors;
        private System.Windows.Forms.RadioButton RboPositiveSentiment;
        private System.Windows.Forms.RadioButton RboNegativeSentiments;
        private System.Windows.Forms.RadioButton RboNamedEntities;
        private System.Windows.Forms.RadioButton RboPercentagePhrases;
    }
}
