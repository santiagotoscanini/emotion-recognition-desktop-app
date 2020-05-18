using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    public partial class AddEntityUserControl : UserControl
    {
        private const string EmptyText = "";
        private const string NoEntitiesRegisteredErrorMessage = "No hay entidades registradas";
        private const string CantSaveEmptyEntityErrorMessage = "No se pueden guardar entidades vacías";
        private const string EntityAlreadyExistsErrorMessage = "Esa entidad ya existe";

        public AddEntityUserControl()
        {
            InitializeComponent();
            LoadEntityList();
        }

        private void LoadEntityList()
        {
            //TODO: here we load the registered entities, else it shows a message
            ValidateIfIsEmpty();
        }

        private void ValidateIfIsEmpty()
        {
            if (LstEntites.Items.Count == 0)
            {
                ShowErrorMessageInList(NoEntitiesRegisteredErrorMessage);
            }
            else
            {
                HideErrorMessageInList();
            }
        }

        private void ShowErrorMessageInList(string ErrorMessage)
        {
            LblErrorMessageEmptyList.Text = ErrorMessage;
            LblErrorMessageEmptyList.Visible = true;
        }

        private void HideErrorMessageInList()
        {
            LblErrorMessageEmptyList.Text = EmptyText;
            LblErrorMessageEmptyList.Visible = false;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            HideErrorMessages();
            AddEntityInTheList();
            ClearFields();
        }

        private void AddEntityInTheList()
        {
            if (CheckDataToCreate())
            {
                //TODO: save and update with the result if it was saved or not
                LstEntites.Items.Add(TxtNewEntity.Text);
                ActualizeEntityList(true);
            }
        }

        private bool CheckDataToCreate()
        {
            if (TxtNewEntity.Text.Length > 0)
            {
                return true;
            }

            ShowErrorMessageInCreate(CantSaveEmptyEntityErrorMessage);
            return false;
        }

        private void ActualizeEntityList(bool WasCreated) {
            if (WasCreated)
            {
                LoadEntityList();
            }
            else
            {
                ShowErrorMessageInCreate(EntityAlreadyExistsErrorMessage);
            }
        }

        

        private void ShowErrorMessageInCreate(string ErrorMessage)
        {
            LblErrorMessageEmptyData.Text = ErrorMessage;
        }

        private void HideErrorMessages()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
        }

        private void ClearFields()
        {
            TxtNewEntity.Clear();
        }
    }
}
