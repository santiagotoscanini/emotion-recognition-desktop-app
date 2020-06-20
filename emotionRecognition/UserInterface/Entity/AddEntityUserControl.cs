using BusinessLogic;
using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    public partial class AddEntityUserControl : UserControl
    {
        private const string CantSaveEmptyEntityErrorMessage = "No se pueden guardar entidades vacías";
        private const string NoEntitiesRegisteredErrorMessage = "No hay entidades registradas";
        private const string EntityAlreadyExistsErrorMessage = "Esa entidad ya existe";
        private const string EmptyText = "";

        private readonly BusinessLogicController controller;

        public AddEntityUserControl(IRepository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            LoadEntityList();
        }

        private void LoadEntityList()
        {
            ClearList();
            foreach (Entity entity in controller.GetEntities())
            {
                LstEntites.Items.Add(entity.Name);
            }
            ValidateIfIsEmpty();
        }

        private void ClearList()
        {
            LstEntites.Items.Clear();
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
                string entityName = TxtNewEntity.Text;
                bool wasCreated = controller.AddEntity(entityName);
                ActualizeEntityList(wasCreated);
            }
        }

        private bool CheckDataToCreate()
        {
            if (!string.IsNullOrWhiteSpace(TxtNewEntity.Text))
            {
                return true;
            }

            ShowErrorMessageInCreate(CantSaveEmptyEntityErrorMessage);
            return false;
        }

        private void ActualizeEntityList(bool WasCreated)
        {
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
