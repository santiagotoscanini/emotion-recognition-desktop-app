﻿namespace UserInterface
{
    partial class AuthorReportUserControl
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
            this.GrdAuthors = new System.Windows.Forms.DataGridView();
            this.LblAuthors = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.LblNoAuthor = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Negativas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdAuthors
            // 
            this.GrdAuthors.AllowUserToAddRows = false;
            this.GrdAuthors.AllowUserToDeleteRows = false;
            this.GrdAuthors.AllowUserToOrderColumns = true;
            this.GrdAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Surname,
            this.UserName,
            this.DateOfBirth,
            this.Porcentaje,
            this.Negativas,
            this.Entities,
            this.PromedioDiario});
            this.GrdAuthors.Location = new System.Drawing.Point(13, 43);
            this.GrdAuthors.MultiSelect = false;
            this.GrdAuthors.Name = "GrdAuthors";
            this.GrdAuthors.ReadOnly = true;
            this.GrdAuthors.RowHeadersVisible = false;
            this.GrdAuthors.RowHeadersWidth = 51;
            this.GrdAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdAuthors.Size = new System.Drawing.Size(503, 206);
            this.GrdAuthors.TabIndex = 4;
            // 
            // LblAuthors
            // 
            this.LblAuthors.AutoSize = true;
            this.LblAuthors.Location = new System.Drawing.Point(50, 13);
            this.LblAuthors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAuthors.Name = "LblAuthors";
            this.LblAuthors.Size = new System.Drawing.Size(43, 13);
            this.LblAuthors.TabIndex = 3;
            this.LblAuthors.Text = "Autores";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(129, 262);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(98, 24);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Borrar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Location = new System.Drawing.Point(310, 262);
            this.BtnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(98, 24);
            this.BtnModify.TabIndex = 6;
            this.BtnModify.Text = "Modificar";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // LblNoAuthor
            // 
            this.LblNoAuthor.AutoSize = true;
            this.LblNoAuthor.ForeColor = System.Drawing.Color.Red;
            this.LblNoAuthor.Location = new System.Drawing.Point(210, 288);
            this.LblNoAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNoAuthor.Name = "LblNoAuthor";
            this.LblNoAuthor.Size = new System.Drawing.Size(0, 13);
            this.LblNoAuthor.TabIndex = 36;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Apellido";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 125;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre de usuario";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Fecha de nacimiento";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 125;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje de frases positivas";
            this.Porcentaje.MinimumWidth = 6;
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 125;
            // 
            // Negativas
            // 
            this.Negativas.HeaderText = "Porcentajes de frases negativas";
            this.Negativas.Name = "Negativas";
            this.Negativas.ReadOnly = true;
            // 
            // Entities
            // 
            this.Entities.HeaderText = "Entidades distintas mencionadas";
            this.Entities.MinimumWidth = 6;
            this.Entities.Name = "Entities";
            this.Entities.ReadOnly = true;
            this.Entities.Width = 125;
            // 
            // PromedioDiario
            // 
            this.PromedioDiario.HeaderText = "Promedio de frases por dia";
            this.PromedioDiario.MinimumWidth = 6;
            this.PromedioDiario.Name = "PromedioDiario";
            this.PromedioDiario.ReadOnly = true;
            this.PromedioDiario.Width = 125;
            // 
            // AuthorReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblNoAuthor);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.GrdAuthors);
            this.Controls.Add(this.LblAuthors);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AuthorReportUserControl";
            this.Size = new System.Drawing.Size(532, 309);
            ((System.ComponentModel.ISupportInitialize)(this.GrdAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdAuthors;
        private System.Windows.Forms.Label LblAuthors;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Label LblNoAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Negativas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entities;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioDiario;
    }
}
