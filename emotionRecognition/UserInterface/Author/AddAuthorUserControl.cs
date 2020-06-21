using System;
using System.Windows.Forms;
using BusinessLogic;

namespace UserInterface
{
    public partial class AddAuthorUserControl : UserControl
    {
        private const string NameEmptyErrorMessage = "El nombre no puede ser vacio";
        private const string SurnameEmptyErrorMessage = "El apellido no puede ser vacio";
        private const string TxtUsernameEmptyError = "El nombre de usuario no puede ser vacio";

        private const string SuccessMessage = "Autor agregado satisfactoriamente";
        private const string EmptyText = "";

        private const int MaxDateOfBirth = -100;
        private const int MinDateOfBirth = -13;
        private string authorUsername;

        private BusinessLogicController business { get; set; }

        public AddAuthorUserControl(BusinessLogicController business, string authorUsername)
        {
            this.authorUsername = authorUsername;
            this.business = business;
            InitializeComponent();
            SetRangeOfDateOfBirth();
            if (this.authorUsername != null)
            {
                LoadAuthorData();
            }
        }

        private void LoadAuthorData()
        {
            //TODO            
        }

        private void SetRangeOfDateOfBirth()
        {
            DtpDateOfBirth.MaxDate = DateTime.Now.AddYears(MinDateOfBirth);
            DtpDateOfBirth.MinDate = DateTime.Now.AddYears(MaxDateOfBirth);
            DtpDateOfBirth.Text = DateTime.Now.AddYears(MinDateOfBirth).ToString();
        }

        private void BtnCreateAuthor_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            if (!DataIsIncorrect())
            {
                CreateOrUpdateAuthor();
                ShowSucessfullMessage();
                ClearFields();
            }
        }

        private void CreateOrUpdateAuthor()
        {
            //TODO
        }

        private void ShowSucessfullMessage()
        {
            TxtSuccess.Text = SuccessMessage;
        }

        private void ClearFields()
        {
            TxtName.Text = EmptyText;
            TxtSurname.Text = EmptyText;
            TxtUserName.Text = EmptyText;
        }

        private void HideErrorMessage()
        {
            LblNoName.Text = EmptyText;
            LblNoSurname.Text = EmptyText;
            LblNoUsername.Text = EmptyText;
        }

        private bool DataIsIncorrect()
        {
            bool areAtLeastOneFieldEmpty = false;
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                LblNoName.Text = NameEmptyErrorMessage;
                areAtLeastOneFieldEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(TxtSurname.Text))
            {
                LblNoSurname.Text = SurnameEmptyErrorMessage;
                areAtLeastOneFieldEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(TxtUserName.Text))
            {
                LblNoUsername.Text = TxtUsernameEmptyError;
                areAtLeastOneFieldEmpty = true;
            }
            return areAtLeastOneFieldEmpty;
        }
    }
}
