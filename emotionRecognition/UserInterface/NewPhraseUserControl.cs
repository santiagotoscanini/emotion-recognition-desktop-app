using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class NewPhraseUserControl : UserControl
    {
        private const string CanNotSaveEmptyData = "Asegurate de completar todos los campos";
        private const string EmptyText = "";

        public NewPhraseUserControl()
        {
            InitializeComponent();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            if (CheckData())
            {
                CreatePhrase();
            }
        }

        private void HideErrorMessage()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
        }

        private bool CheckData()
        {
            if (TxtPhrase.Text.Length > 0)
            {
                return true;
            }

            ShowErrorMessage(CanNotSaveEmptyData);
            return false;
        }

        private void ShowErrorMessage(string ErrorMessage)
        {
            LblErrorMessageEmptyData.Text = ErrorMessage;
        }

        private void CreatePhrase()
        {
            //TODO: here we add the phrase in the sistem
            ClearFields();
        }

        private void ClearFields()
        {
            TxtPhrase.Text = EmptyText;
        }
    }
}
