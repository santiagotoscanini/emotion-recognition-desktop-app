using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class NegativeSentimentUserControl : UserControl
    {
        private const string SentimentAlreadyExist = "Ese sentimiento ya existe";
        private const string NoSentimentsRegister = "No hay sentimientos negativos registrados";
        private const string CanNotSaveEmptyData = "El texto del sentimiento no puede ser vacío";
        private const string CanNotDeleteUsingSentiment = "Ese sentimiento esta siendo utilizado por al menos una frase, no puede ser eliminado";
        private const string SelectDataToDelete = "Debes seleccionar un sentimiento para poder eliminarlo";
        private const string EmptyText = "";

        private readonly BusinessLogicController controller;

        public NegativeSentimentUserControl(IRepository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            LoadSentimentsList();
        }

        private void LoadSentimentsList()
        {
            ClearList();
            foreach (Sentiment sentiment in controller.GetNegativeSentiments())
            {
                LstSentiments.Items.Add(sentiment.Text);
            }
            ValidateIfIsEmpty();
        }

        private void ClearList()
        {
            LstSentiments.Items.Clear();
        }

        private void ValidateIfIsEmpty()
        {
            if (LstSentiments.Items.Count == 0)
            {
                ShowErrorMessageInList(NoSentimentsRegister);
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
            AddNegativeSentimentInTheList();
            ClearFields();
        }

        private void HideErrorMessages()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
            LblErrorMessageNotSelectedItem.Text = EmptyText;
        }

        private void AddNegativeSentimentInTheList()
        {
            if (CheckData())
            {
                string sentimentText = TxtNewSentiment.Text;
                bool wasCreated = controller.AddNegativeSentiment(sentimentText);
                ActualizeSentimentsList(wasCreated, true);
            }
        }

        private bool CheckData()
        {
            if (!string.IsNullOrWhiteSpace(TxtNewSentiment.Text))
            {
                return true;
            }

            ShowErrorMessageInCreate(CanNotSaveEmptyData);
            return false;
        }

        private void ShowErrorMessageInCreate(string ErrorMessage)
        {
            LblErrorMessageEmptyData.Text = ErrorMessage;
        }

        private void ActualizeSentimentsList(bool WasModified, bool wasCreating)
        {
            if (WasModified)
            {
                LoadSentimentsList();
            }
            else if (wasCreating)
            {
                ShowErrorMessageInCreate(SentimentAlreadyExist);
            }
            else
            {
                ShowErrorMessageInDelete(CanNotDeleteUsingSentiment);
            }

        }

        private void ClearFields()
        {
            TxtNewSentiment.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            HideErrorMessages();
            DeleteNegativeSentiment();
        }

        private void DeleteNegativeSentiment()
        {
            if (CheckDataToDelete())
            {
                string deletedSentiment = LstSentiments.SelectedItem.ToString();
                bool wasDeleted = controller.DeleteNegativeSentiment(deletedSentiment);
                ActualizeSentimentsList(wasDeleted, false);
            }
        }

        private bool CheckDataToDelete()
        {
            if (LstSentiments.SelectedItem != null)
            {
                return true;
            }

            ShowErrorMessageInDelete(SelectDataToDelete);
            return false;
        }

        private void ShowErrorMessageInDelete(string ErrorMessage)
        {
            LblErrorMessageNotSelectedItem.Text = ErrorMessage;
        }
    }
}
