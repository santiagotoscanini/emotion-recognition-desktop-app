using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class NewPhraseUserControl : UserControl
    {
        private const string CanNotSaveEmptyData = "El texto de la frase no puede estar vacio o ser unicamente espacios";
        private const string SuccessMessage = "Frase agregada satisfactoriamente";
        private const string EmptyText = "";

        private const int MaxDateOfBirth = -100;

        private readonly BusinessLogicController controller;

        public NewPhraseUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            LoadAuthor();
            SetCalendarLimits();
        }

        private void SetCalendarLimits()
        {
            DtpCalendar.MaxDate = DateTime.Now;
            DtpCalendar.MinDate = DateTime.Now.AddYears(MaxDateOfBirth);
            DtpCalendar.Text = DateTime.Now.ToString();
        }

        private void LoadAuthor()
        {
            LoadAuthorList();
            if (LbxAuthors.Items.Count == 0)
            {
                NoAuthorOnSystem();
            }
            else
            {
                LbxAuthors.SelectedIndex = 0;
            }
        }

        private void LoadAuthorList()
        {
            //TODO
            //foreach (Entity author in controller.GetAuthors())
            //{
            //    LbxAuthors.Items.Add(entity.Name);
            //}
        }

        private void NoAuthorOnSystem()
        {
            LblNoAuthorError.Visible = true;
            LbxAuthors.Enabled = false;
            BtnAccept.Enabled = false;
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

            ShowErrorMessage();
            return false;
        }

        private void ShowErrorMessage()
        {
            LblErrorMessageEmptyData.Text = CanNotSaveEmptyData;
        }

        private void CreatePhrase()
        {
            string phraseText = TxtPhrase.Text;
            DateTime calendar = DtpCalendar.Value;
            DateTime hours = DtpTime.Value;

            DateTime dateTime = new DateTime(calendar.Year, calendar.Month, calendar.Day, hours.Hour, hours.Minute, hours.Second);
            //TODO: Change add phrase
        }

        private void ClearFields()
        {
            TxtPhrase.Text = EmptyText;
        }
    }
}
