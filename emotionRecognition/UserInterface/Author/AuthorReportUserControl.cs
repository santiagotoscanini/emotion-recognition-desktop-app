﻿using System;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Entities;

namespace UserInterface
{
    public partial class AuthorReportUserControl : UserControl
    {
        private const string NoSelectionErrorMessage = "Debe elegir un autor";
        private const string EmptyMessage = "";

        private BusinessLogicController businessLogicController;
        private AuthorUserControl authorUserControl;

        public AuthorReportUserControl(BusinessLogicController businessLogicController, AuthorUserControl authorUserControl)
        {
            this.businessLogicController = businessLogicController;
            this.authorUserControl = authorUserControl;
            InitializeComponent();
            LoadAuthorsReport();
        }

        private void LoadAuthorsReport()
        {
            GrdAuthors.Rows.Clear();
            foreach (Author author in businessLogicController.GetAuthors())
            {
                GrdAuthors.Rows.Add(
                    author.Name,
                    author.Surname,
                    author.Username,
                    author.Birthdate.ToString("dd/MM/yyyy"),
                    author.GetPercentageOfPositivePhrases(),
                    author.GetPercentageOfNegativePhrases(),
                    author.NumberOfDistinctEntitiesMentioned,
                    author.GetAvgOfPhrasesPerDay()
                    );
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClearFields();

            if (!DataIsIncorrect())
            {
                String authorUsername = (string)GrdAuthors.CurrentRow.Cells["UserName"].Value;
                businessLogicController.DeleteAuthorByUsername(authorUsername);
                LoadAuthorsReport();
            }
        }

        private void ClearFields()
        {
            LblNoAuthor.Text = EmptyMessage;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            ClearFields();

            if (!DataIsIncorrect())
            {
                string authorUsername = (string)GrdAuthors.CurrentRow.Cells["UserName"].Value;

                authorUserControl.OnModify(authorUsername);
            }
        }

        private bool DataIsIncorrect()
        {
            bool areAtLeastOneFieldEmpty = false;
            if (GrdAuthors.CurrentCell == null)
            {
                LblNoAuthor.Text = NoSelectionErrorMessage;
                areAtLeastOneFieldEmpty = true;
            }

            return areAtLeastOneFieldEmpty;
        }

    }
}
