using System;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class AuthorReportUserControl : UserControl
    {
        private const string NoSelectionErrorMessage = "Debe elegir un autor";
        private const string EmptyMessage = "";

        private BusinessLogicController controller;
        private AuthorUserControl authorUserControl;

        public AuthorReportUserControl(BusinessLogicController controller, AuthorUserControl authorUserControl)
        {
            this.controller = controller;
            this.authorUserControl = authorUserControl;
            InitializeComponent();
            LoadAuthorsReport();
        }

        private void LoadAuthorsReport()
        {
            //TODO
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClearFields();

            if (!DataIsIncorrect())
            {
                String authorUsername = (string)GrdAuthors.CurrentRow.Cells["UserName"].Value;
                //TODO
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
                String authorUsername = (string)GrdAuthors.CurrentRow.Cells["UserName"].Value;

                authorUserControl.ModifiyAuthor(authorUsername);
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
