using System;

namespace emotionRecognition
{
    partial class MainWindow
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlMain = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.BtnAlarms = new System.Windows.Forms.Button();
            this.BtnEntities = new System.Windows.Forms.Button();
            this.BtnPhrases = new System.Windows.Forms.Button();
            this.BtnSentiments = new System.Windows.Forms.Button();
            this.PnlMain.SuspendLayout();
            this.PnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.LblMessage);
            this.PnlMain.Location = new System.Drawing.Point(301, 1);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(804, 541);
            this.PnlMain.TabIndex = 0;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(369, 241);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(91, 20);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Bienvenido!";
            // 
            // PnlOptions
            // 
            this.PnlOptions.Controls.Add(this.BtnAlarms);
            this.PnlOptions.Controls.Add(this.BtnEntities);
            this.PnlOptions.Controls.Add(this.BtnPhrases);
            this.PnlOptions.Controls.Add(this.BtnSentiments);
            this.PnlOptions.Location = new System.Drawing.Point(-1, 1);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(303, 541);
            this.PnlOptions.TabIndex = 1;
            // 
            // BtnAlarms
            // 
            this.BtnAlarms.Location = new System.Drawing.Point(0, 404);
            this.BtnAlarms.Name = "BtnAlarms";
            this.BtnAlarms.Size = new System.Drawing.Size(303, 137);
            this.BtnAlarms.TabIndex = 3;
            this.BtnAlarms.Text = "Alarmas";
            this.BtnAlarms.UseVisualStyleBackColor = true;
            this.BtnAlarms.Click += new System.EventHandler(this.BtnAlarms_Click);
            // 
            // BtnEntities
            // 
            this.BtnEntities.Location = new System.Drawing.Point(0, 269);
            this.BtnEntities.Name = "BtnEntities";
            this.BtnEntities.Size = new System.Drawing.Size(303, 137);
            this.BtnEntities.TabIndex = 2;
            this.BtnEntities.Text = "Entidades";
            this.BtnEntities.UseVisualStyleBackColor = true;
            this.BtnEntities.Click += new System.EventHandler(this.BtnEntities_Click);
            // 
            // BtnPhrases
            // 
            this.BtnPhrases.Location = new System.Drawing.Point(0, 135);
            this.BtnPhrases.Name = "BtnPhrases";
            this.BtnPhrases.Size = new System.Drawing.Size(303, 137);
            this.BtnPhrases.TabIndex = 1;
            this.BtnPhrases.Text = "Frases";
            this.BtnPhrases.UseVisualStyleBackColor = true;
            this.BtnPhrases.Click += new System.EventHandler(this.BtnPhrases_Click);
            // 
            // BtnSentiments
            // 
            this.BtnSentiments.Location = new System.Drawing.Point(0, 0);
            this.BtnSentiments.Name = "BtnSentiments";
            this.BtnSentiments.Size = new System.Drawing.Size(303, 137);
            this.BtnSentiments.TabIndex = 0;
            this.BtnSentiments.Text = "Sentimientos";
            this.BtnSentiments.UseVisualStyleBackColor = true;
            this.BtnSentiments.Click += new System.EventHandler(this.BtnSentiments_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1104, 541);
            this.Controls.Add(this.PnlOptions);
            this.Controls.Add(this.PnlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Welcome";
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.PnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel PnlOptions;
        private System.Windows.Forms.Button BtnAlarms;
        private System.Windows.Forms.Button BtnEntities;
        private System.Windows.Forms.Button BtnPhrases;
        private System.Windows.Forms.Button BtnSentiments;
        private System.Windows.Forms.Label LblMessage;
    }
}

