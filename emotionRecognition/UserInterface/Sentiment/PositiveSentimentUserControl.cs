using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PositiveSentimentUserControl : UserControl
    {
        private const string SentimentAlreadyExistErrorMessage = "Ese sentimiento ya existe";
        private const string NoPositiveSentimentsRegisteredErrorMessage = "No hay sentimientos positivos registrados";
        private const string SelectSentimentToDeleteErrorMessage = "Debes seleccionar un sentimiento para poder eliminarlo";
        private const string CanNotSaveEmptyData = "El texto del sentimiento no puede ser vacío";
        private const string CanNotDeleteUsingSentiment = "Ese sentimiento esta siendo utilizado por al menos una frase, no puede ser eliminado";
        private const string EmptyText = "";

        private readonly BusinessLogicController controller;

        public PositiveSentimentUserControl(Repository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            LoadSentimentsList();
        }

        private void LoadSentimentsList()
        {
            ClearList();
            foreach (Sentiment sentiment in controller.GetPositiveSentiments())
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
                ShowErrorMessageInList(NoPositiveSentimentsRegisteredErrorMessage);
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
            AddPositiveSentimentInTheList();
            ClearFields();
        }

        private void HideErrorMessages()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
            LblErrorMessageNotSelectedSentiment.Text = EmptyText;
        }

        private void AddPositiveSentimentInTheList()
        {
            if (CheckDataToCreate())
            {
                string sentimentText = TxtNewSentiment.Text;
                bool wasCreated = controller.AddPositiveSentiment(sentimentText);
                ActualizeSentimentsList(wasCreated, true);
            }
        }

        private bool CheckDataToCreate()
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
                ShowErrorMessageInCreate(SentimentAlreadyExistErrorMessage);
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
            DeletePositiveSentiment();
        }

        private void DeletePositiveSentiment()
        {
            if (CheckDataToDelete())
            {
                string deletedSentiment = LstSentiments.SelectedItem.ToString();
                bool wasDeleted = controller.DeletePositiveSentiment(deletedSentiment);
                ActualizeSentimentsList(wasDeleted, false);
            }
        }

        private bool CheckDataToDelete()
        {
            if (LstSentiments.SelectedItem != null)
            {
                return true;
            }

            ShowErrorMessageInDelete(SelectSentimentToDeleteErrorMessage);
            return false;
        }

        private void ShowErrorMessageInDelete(string ErrorMessage)
        {
            LblErrorMessageNotSelectedSentiment.Text = ErrorMessage;
        }
    }
}
