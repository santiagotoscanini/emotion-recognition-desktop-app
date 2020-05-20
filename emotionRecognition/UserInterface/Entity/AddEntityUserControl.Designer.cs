namespace emotionRecognition
{
    partial class AddEntityUserControl
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
            this.TxtNewEntity = new System.Windows.Forms.TextBox();
            this.LblNewEnity = new System.Windows.Forms.Label();
            this.LblEntities = new System.Windows.Forms.Label();
            this.LstEntites = new System.Windows.Forms.ListBox();
            this.LblRegisterEnities = new System.Windows.Forms.Label();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.LblErrorMessageEmptyData = new System.Windows.Forms.Label();
            this.LblErrorMessageEmptyList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNewEntity
            // 
            this.TxtNewEntity.Location = new System.Drawing.Point(49, 80);
            this.TxtNewEntity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtNewEntity.Name = "TxtNewEntity";
            this.TxtNewEntity.Size = new System.Drawing.Size(320, 20);
            this.TxtNewEntity.TabIndex = 0;
            // 
            // LblNewEnity
            // 
            this.LblNewEnity.AutoSize = true;
            this.LblNewEnity.Location = new System.Drawing.Point(47, 53);
            this.LblNewEnity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewEnity.Name = "LblNewEnity";
            this.LblNewEnity.Size = new System.Drawing.Size(123, 13);
            this.LblNewEnity.TabIndex = 14;
            this.LblNewEnity.Text = "Registrar nueva entidad:";
            this.LblNewEnity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEntities
            // 
            this.LblEntities.AutoSize = true;
            this.LblEntities.Location = new System.Drawing.Point(207, 17);
            this.LblEntities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEntities.Name = "LblEntities";
            this.LblEntities.Size = new System.Drawing.Size(54, 13);
            this.LblEntities.TabIndex = 13;
            this.LblEntities.Text = "Entidades";
            // 
            // LstEntites
            // 
            this.LstEntites.FormattingEnabled = true;
            this.LstEntites.Location = new System.Drawing.Point(49, 149);
            this.LstEntites.Margin = new System.Windows.Forms.Padding(2);
            this.LstEntites.Name = "LstEntites";
            this.LstEntites.Size = new System.Drawing.Size(320, 173);
            this.LstEntites.TabIndex = 2;
            // 
            // LblRegisterEnities
            // 
            this.LblRegisterEnities.AutoSize = true;
            this.LblRegisterEnities.Location = new System.Drawing.Point(47, 122);
            this.LblRegisterEnities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRegisterEnities.Name = "LblRegisterEnities";
            this.LblRegisterEnities.Size = new System.Drawing.Size(111, 13);
            this.LblRegisterEnities.TabIndex = 19;
            this.LblRegisterEnities.Text = "Entidades registradas:";
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(395, 75);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(59, 27);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // LblErrorMessageEmptyData
            // 
            this.LblErrorMessageEmptyData.AutoSize = true;
            this.LblErrorMessageEmptyData.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessageEmptyData.Location = new System.Drawing.Point(47, 102);
            this.LblErrorMessageEmptyData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMessageEmptyData.Name = "LblErrorMessageEmptyData";
            this.LblErrorMessageEmptyData.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessageEmptyData.TabIndex = 23;
            // 
            // LblErrorMessageEmptyList
            // 
            this.LblErrorMessageEmptyList.AutoSize = true;
            this.LblErrorMessageEmptyList.Location = new System.Drawing.Point(125, 213);
            this.LblErrorMessageEmptyList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblErrorMessageEmptyList.Name = "LblErrorMessageEmptyList";
            this.LblErrorMessageEmptyList.Size = new System.Drawing.Size(0, 13);
            this.LblErrorMessageEmptyList.TabIndex = 25;
            // 
            // AddEntityUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblErrorMessageEmptyList);
            this.Controls.Add(this.LblErrorMessageEmptyData);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.LblRegisterEnities);
            this.Controls.Add(this.LstEntites);
            this.Controls.Add(this.TxtNewEntity);
            this.Controls.Add(this.LblNewEnity);
            this.Controls.Add(this.LblEntities);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddEntityUserControl";
            this.Size = new System.Drawing.Size(536, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNewEntity;
        private System.Windows.Forms.Label LblNewEnity;
        private System.Windows.Forms.Label LblEntities;
        private System.Windows.Forms.ListBox LstEntites;
        private System.Windows.Forms.Label LblRegisterEnities;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Label LblErrorMessageEmptyData;
        private System.Windows.Forms.Label LblErrorMessageEmptyList;
    }
}
