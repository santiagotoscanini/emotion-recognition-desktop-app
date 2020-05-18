using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PhraseReportUserControl : UserControl
    {
        private const string NoPhrasesRegister = "No hay frases registradas";

        public PhraseReportUserControl()
        {
            InitializeComponent();
            LoadPhrasesReport();
        }

        private void LoadPhrasesReport()
        {
            //TODO: here we will load the list of saved phrases
            ValidateIfIsEmpty();
        }

        private void ValidateIfIsEmpty()
        {
            if (LstPhrases.Items.Count == 0)
            {
                ShowErrorMessage(NoPhrasesRegister);
            }
        }

        private void ShowErrorMessage(string ErrorMessage)
        {
            LblErrorMessageEmptyList.Text = ErrorMessage;
            LblErrorMessageEmptyList.Visible = true;
        }
    }
}
