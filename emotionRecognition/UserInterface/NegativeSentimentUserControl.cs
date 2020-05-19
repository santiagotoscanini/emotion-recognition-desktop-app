using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class NegativeSentimentUserControl : UserControl
    {
        private const string SentimentAlreadyExist = "Ese sentimiento ya existe";
        private const string NoSentimentsRegister = "No hay sentimientos negativos registrados";
        private const string CanNotSaveEmptyData = "No se pueden guardar sentimientos vacíos";
        private const string SelectDataToDelete = "Debes seleccionar un sentimiento para poder eliminarlo";
        private const string EmptyText = "";
        private BusinessLogicController controller;

        public NegativeSentimentUserControl(Repository repository)
        {
            InitializeComponent();
            this.controller = new BusinessLogicController(repository);
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
                ActualizeSentimentsList(wasCreated);
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

        private void ActualizeSentimentsList(bool WasModified)
        {
            if (WasModified)
            {
                LoadSentimentsList();
            }
            else
            {
                ShowErrorMessageInCreate(SentimentAlreadyExist);
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
                ActualizeSentimentsList(wasDeleted);
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
