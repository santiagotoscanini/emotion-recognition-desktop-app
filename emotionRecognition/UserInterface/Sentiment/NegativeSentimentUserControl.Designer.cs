namespace UserInterface
{
    partial class NegativeSentimentUserControl
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
            this.LblErrorMessageNotSelectedItem = new System.Windows.Forms.Label();
            this.LblErrorMessageEmptyData = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblSentiments = new System.Windows.Forms.Label();
            this.LstSentiments = new System.Windows.Forms.ListBox();
            this.TxtNewSentiment = new System.Windows.Forms.TextBox();
            this.LblNewSentiment = new System.Windows.Forms.Label();
            this.LblErrorMessageEmptyList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblErrorMessageNotSelectedItem
            // 
            this.LblErrorMessageNotSelectedItem.AutoSize = true;
            this.LblErrorMessageNotSelectedItem.BackColor = System.Drawing.Color.Transparent;
            this.LblErrorMessageNotSelectedItem.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageNotSelectedItem.Location = new System.Drawing.Point(55, 287);
            this.LblErrorMessageNotSelectedItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMessageNotSelectedItem.Name = "LblErrorMessageNotSelectedItem";
            this.LblErrorMessageNotSelectedItem.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessageNotSelectedItem.TabIndex = 48;
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(55, 59);
            this.LblErrorMessageEmptyData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessageEmptyData.TabIndex = 47;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(404, 32);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(59, 27);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(404, 101);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(59, 27);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblSentiments
            // 
            this.LblSentiments.AutoSize = true;
            this.LblSentiments.Location = new System.Drawing.Point(55, 85);
            this.LblSentiments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSentiments.Name = "LblSentiments";
            this.LblSentiments.Size = new System.Drawing.Size(173, 13);
            this.LblSentiments.TabIndex = 44;
            this.LblSentiments.Text = "Sentimientos negativos registrados:";
            // 
            // LstSentiments
            // 
            this.LstSentiments.FormattingEnabled = true;
            this.LstSentiments.Location = new System.Drawing.Point(58, 107);
            this.LstSentiments.Margin = new System.Windows.Forms.Padding(2);
            this.LstSentiments.Name = "LstSentiments";
            this.LstSentiments.Size = new System.Drawing.Size(320, 173);
            this.LstSentiments.TabIndex = 2;
            // 
            // TxtNewSentiment
            // 
            this.TxtNewSentiment.Location = new System.Drawing.Point(58, 37);
            this.TxtNewSentiment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtNewSentiment.Name = "TxtNewSentiment";
            this.TxtNewSentiment.Size = new System.Drawing.Size(320, 20);
            this.TxtNewSentiment.TabIndex = 0;
            // 
            // LblNewSentiment
            // 
            this.LblNewSentiment.AutoSize = true;
            this.LblNewSentiment.Location = new System.Drawing.Point(55, 10);
            this.LblNewSentiment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewSentiment.Name = "LblNewSentiment";
            this.LblNewSentiment.Size = new System.Drawing.Size(185, 13);
            this.LblNewSentiment.TabIndex = 41;
            this.LblNewSentiment.Text = "Registrar nuevo sentimiento negativo:";
            this.LblNewSentiment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblErrorMessageEmptyList
            // 
            this.LblErrorMessageEmptyList.AutoSize = true;
            this.LblErrorMessageEmptyList.Location = new System.Drawing.Point(147, 180);
            this.LblErrorMessageEmptyList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMessageEmptyList.Name = "LblErrorMessageEmptyList";
            this.LblErrorMessageEmptyList.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessageEmptyList.TabIndex = 49;
            // 
            // NegativeSentimentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMessageEmptyList);
            this.Controls.Add(this.LblErrorMessageNotSelectedItem);
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblSentiments);
            this.Controls.Add(this.LstSentiments);
            this.Controls.Add(this.TxtNewSentiment);
            this.Controls.Add(this.LblNewSentiment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NegativeSentimentUserControl";
            this.Size = new System.Drawing.Size(532, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblErrorMessageNotSelectedItem;
        private System.Windows.Forms.Label LblErrorMessageEmptyData;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblSentiments;
        private System.Windows.Forms.ListBox LstSentiments;
        private System.Windows.Forms.TextBox TxtNewSentiment;
        private System.Windows.Forms.Label LblNewSentiment;
        private System.Windows.Forms.Label LblErrorMessageEmptyList;
    }
}
