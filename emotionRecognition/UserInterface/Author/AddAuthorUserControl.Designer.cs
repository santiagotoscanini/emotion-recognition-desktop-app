namespace UserInterface
{
    partial class AddAuthorUserControl
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblPhrase = new System.Windows.Forms.Label();
            this.LblNewPhrase = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCreateAuthor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNoName = new System.Windows.Forms.Label();
            this.LblNoSurname = new System.Windows.Forms.Label();
            this.LblNoUsername = new System.Windows.Forms.Label();
            this.TxtSuccess = new System.Windows.Forms.Label();
            this.LblUserAlreadyExist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(64, 65);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.MaxLength = 15;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(356, 20);
            this.TxtName.TabIndex = 2;
            // 
            // LblPhrase
            // 
            this.LblPhrase.AutoSize = true;
            this.LblPhrase.Location = new System.Drawing.Point(63, 43);
            this.LblPhrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPhrase.Name = "LblPhrase";
            this.LblPhrase.Size = new System.Drawing.Size(47, 13);
            this.LblPhrase.TabIndex = 4;
            this.LblPhrase.Text = "Nombre:";
            // 
            // LblNewPhrase
            // 
            this.LblNewPhrase.AutoSize = true;
            this.LblNewPhrase.Location = new System.Drawing.Point(204, 14);
            this.LblNewPhrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNewPhrase.Name = "LblNewPhrase";
            this.LblNewPhrase.Size = new System.Drawing.Size(133, 13);
            this.LblNewPhrase.TabIndex = 3;
            this.LblNewPhrase.Text = "Registrar o actualizar autor";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(64, 119);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSurname.MaxLength = 15;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(356, 20);
            this.TxtSurname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apellido:";
            // 
            // BtnCreateAuthor
            // 
            this.BtnCreateAuthor.Location = new System.Drawing.Point(286, 263);
            this.BtnCreateAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreateAuthor.Name = "BtnCreateAuthor";
            this.BtnCreateAuthor.Size = new System.Drawing.Size(134, 24);
            this.BtnCreateAuthor.TabIndex = 7;
            this.BtnCreateAuthor.Text = "Crear o actualizar autor";
            this.BtnCreateAuthor.UseVisualStyleBackColor = true;
            this.BtnCreateAuthor.Click += new System.EventHandler(this.BtnCreateAuthor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de usuario:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(64, 174);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.MaxLength = 10;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(356, 20);
            this.TxtUserName.TabIndex = 9;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Location = new System.Drawing.Point(64, 229);
            this.DtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(151, 20);
            this.DtpDateOfBirth.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // LblNoName
            // 
            this.LblNoName.AutoSize = true;
            this.LblNoName.ForeColor = System.Drawing.Color.Red;
            this.LblNoName.Location = new System.Drawing.Point(172, 43);
            this.LblNoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoName.Name = "LblNoName";
            this.LblNoName.Size = new System.Drawing.Size(0, 13);
            this.LblNoName.TabIndex = 33;
            // 
            // LblNoSurname
            // 
            this.LblNoSurname.AutoSize = true;
            this.LblNoSurname.ForeColor = System.Drawing.Color.Red;
            this.LblNoSurname.Location = new System.Drawing.Point(183, 97);
            this.LblNoSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoSurname.Name = "LblNoSurname";
            this.LblNoSurname.Size = new System.Drawing.Size(0, 13);
            this.LblNoSurname.TabIndex = 34;
            // 
            // LblNoUsername
            // 
            this.LblNoUsername.AutoSize = true;
            this.LblNoUsername.ForeColor = System.Drawing.Color.Red;
            this.LblNoUsername.Location = new System.Drawing.Point(183, 150);
            this.LblNoUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoUsername.Name = "LblNoUsername";
            this.LblNoUsername.Size = new System.Drawing.Size(0, 13);
            this.LblNoUsername.TabIndex = 35;
            // 
            // TxtSuccess
            // 
            this.TxtSuccess.AutoSize = true;
            this.TxtSuccess.ForeColor = System.Drawing.Color.GreenYellow;
            this.TxtSuccess.Location = new System.Drawing.Point(63, 274);
            this.TxtSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtSuccess.Name = "TxtSuccess";
            this.TxtSuccess.Size = new System.Drawing.Size(0, 13);
            this.TxtSuccess.TabIndex = 36;
            // 
            // LblUserAlreadyExist
            // 
            this.LblUserAlreadyExist.AutoSize = true;
            this.LblUserAlreadyExist.ForeColor = System.Drawing.Color.Red;
            this.LblUserAlreadyExist.Location = new System.Drawing.Point(283, 229);
            this.LblUserAlreadyExist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUserAlreadyExist.Name = "LblUserAlreadyExist";
            this.LblUserAlreadyExist.Size = new System.Drawing.Size(114, 13);
            this.LblUserAlreadyExist.TabIndex = 37;
            this.LblUserAlreadyExist.Text = "Error, el autor ya existe";
            this.LblUserAlreadyExist.Visible = false;
            // 
            // AddAuthorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUserAlreadyExist);
            this.Controls.Add(this.LblNoUsername);
            this.Controls.Add(this.TxtSuccess);
            this.Controls.Add(this.LblNoSurname);
            this.Controls.Add(this.LblNoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCreateAuthor);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblPhrase);
            this.Controls.Add(this.LblNewPhrase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddAuthorUserControl";
            this.Size = new System.Drawing.Size(532, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblPhrase;
        private System.Windows.Forms.Label LblNewPhrase;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCreateAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNoName;
        private System.Windows.Forms.Label LblNoSurname;
        private System.Windows.Forms.Label LblNoUsername;
        private System.Windows.Forms.Label TxtSuccess;
        private System.Windows.Forms.Label LblUserAlreadyExist;
    }
}
