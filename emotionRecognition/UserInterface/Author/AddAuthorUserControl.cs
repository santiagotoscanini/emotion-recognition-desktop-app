using System;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Entities;

namespace UserInterface
{
    public partial class AddAuthorUserControl : UserControl
    {
        private const string NameEmptyErrorMessage = "El nombre no puede ser vacio";
        private const string SurnameEmptyErrorMessage = "El apellido no puede ser vacio";
        private const string TxtUsernameEmptyError = "El nombre de usuario no puede ser vacio";
        private const string EmptyText = "";
        private const string AddButtonText = "Agregar";
        private const string ModifyButtonText = "Modificar";
        private const string AddTitleText = "Agregar autor";
        private const string ModifyTitleText = "Modificar autor";
        private const string AddSuccessText = "Autor agregado satisfactoriamente";
        private const string ModifySuccessText = "Autor modificado satisfactoriamente";

        private const int MaxDateOfBirth = -100;
        private const int MinDateOfBirth = -13;
        private string authorUsername;

        private BusinessLogicController businessLogicController { get; set; }
        private AuthorUserControl authorUserControl;

        public AddAuthorUserControl(BusinessLogicController businessLogicController, string authorUsername, AuthorUserControl authorUserControl)
        {
            this.authorUsername = authorUsername;
            this.businessLogicController = businessLogicController;
            this.authorUserControl = authorUserControl;
            InitializeComponent();
            setValuesForModifyOrAdd();
            SetRangeOfDateOfBirth();
            if (this.authorUsername != null)
            {
                LoadAuthorData();
            }
        }

        private void setValuesForModifyOrAdd()
        {
            LblUserAlreadyExist.Visible = false;
            if (authorUsername == null)
            {
                LblNewPhrase.Text = AddTitleText;
                BtnCreateAuthor.Text = AddButtonText;
            }
            else
            {
                LblNewPhrase.Text = ModifyTitleText;
                BtnCreateAuthor.Text = ModifyButtonText;
            }
        }

        private void LoadAuthorData()
        {
            Author authorFromDB = businessLogicController.GetAuthorByUsername(authorUsername);
            TxtName.Text = authorFromDB.Name;
            TxtSurname.Text = authorFromDB.Surname;
            TxtUserName.Text = authorFromDB.Username;
            TxtUserName.Enabled = false;
            DtpDateOfBirth.Value = authorFromDB.Birthdate;
        }

        private void SetRangeOfDateOfBirth()
        {
            DtpDateOfBirth.MaxDate = DateTime.Now.AddYears(MinDateOfBirth);
            DtpDateOfBirth.MinDate = DateTime.Now.AddYears(MaxDateOfBirth);
            DtpDateOfBirth.Text = DateTime.Now.AddYears(MinDateOfBirth).ToString();
        }

        private void BtnCreateAuthor_Click(object sender, EventArgs e)
        {
            HideMessages();
            if (!DataIsIncorrect())
            {
                CreateOrUpdateAuthor();
                ClearFields();
                authorUserControl.getBackToReport();
            }
        }

        private void CreateOrUpdateAuthor()
        {
            businessLogicController.AddOrUpdateAuthor(TxtUserName.Text, TxtName.Text, TxtSurname.Text, DtpDateOfBirth.Value);
        }

        private void showSuccessMessage()
        {
            if (authorUsername == null)
            {
                TxtSuccess.Text = AddSuccessText;
            }
            else
            {
                TxtSuccess.Text = ModifySuccessText;
            }
            TxtSuccess.Visible = true;
        }

        private void ClearFields()
        {
            TxtName.Text = EmptyText;
            TxtSurname.Text = EmptyText;
            TxtUserName.Text = EmptyText;
        }

        private void HideMessages()
        {
            LblNoName.Text = EmptyText;
            LblNoSurname.Text = EmptyText;
            LblNoUsername.Text = EmptyText;
            LblUserAlreadyExist.Visible = false;
            TxtSuccess.Visible = false;
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
            
            try
            {
                if (TxtUserName.Text != "" && authorUsername == null)
                {
                    businessLogicController.GetAuthorByUsername(TxtUserName.Text);
                    LblUserAlreadyExist.Visible = true;
                    areAtLeastOneFieldEmpty = true;
                }
            }
            catch (ArgumentException) {
                LblUserAlreadyExist.Visible = false;
            }

            return areAtLeastOneFieldEmpty;
        }
    }
}
