using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class NewPhraseUserControl : UserControl
    {
        private const string CanNotSaveEmptyData = "Asegurate de completar todos los campos";
        private const string EmptyText = "";
        private const string SuccessMessage = "Frase agregada satisfactoriamente";
        private BusinessLogicController controller;

        public NewPhraseUserControl(Repository repository)
        {
            InitializeComponent();
            this.controller = new BusinessLogicController(repository);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            if (CheckData())
            {
                CreatePhrase();
                ShowSucessfullMessage();
                ClearFields();
            }
        }
        private void ShowSucessfullMessage()
        {
            LblSucessful.Text = SuccessMessage;
        }

        private void HideErrorMessage()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
            LblSucessful.Text = EmptyText;
        }

        private bool CheckData()
        {
            if (!string.IsNullOrWhiteSpace(TxtPhrase.Text))
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
            string phraseText = TxtPhrase.Text;
            DateTime calendar = this.DtpCalendar.Value;
            DateTime hours = this.DtpTime.Value;

            DateTime dateTime = new DateTime(calendar.Year,calendar.Month,calendar.Day,hours.Hour,hours.Minute,hours.Second);
            controller.AddPhrase(phraseText, dateTime);
        }

        private void ClearFields()
        {
            TxtPhrase.Text = EmptyText;
        }
    }
}
