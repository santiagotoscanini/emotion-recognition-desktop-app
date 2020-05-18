using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PositiveSentimentUserControl : UserControl
    {
        private const string SentimentAlreadyExistErrorMessage = "Ese sentimiento ya existe";
        private const string NoPositiveSentimentsRegisteredErrorMessage = "No hay sentimientos positivos registrados";
        private const string CanNotSaveEmptyData = "No se pueden guardar sentimientos vacíos";
        private const string SelectSentimentToDeleteErrorMessage = "Debes seleccionar un sentimiento para poder eliminarlo";
        private const string EmptyText = "";

        public PositiveSentimentUserControl()
        {
            InitializeComponent();
            LoadSentimentsList();
        }

        private void LoadSentimentsList()
        {
            //TODO: here we load the registered positive sentiments
            ValidateIfIsEmpty();
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

        private void ShowErrorMessageInList(String ErrorMessage)
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
                //TODO: save and update with the result if it was saved or not
                LstSentiments.Items.Add(TxtNewSentiment.Text);
                ActualizeSentimentsList(true);
            }
        }

        private bool CheckDataToCreate()
        {
            if (TxtNewSentiment.Text.Length > 0)
            {
                return true;
            }

            ShowErrorMessageInCreate(CanNotSaveEmptyData);
            return false;
        }

        private void ShowErrorMessageInCreate(String ErrorMessage)
        {
            LblErrorMessageEmptyData.Text = ErrorMessage;
        }

        private void ActualizeSentimentsList(Boolean WasCreated)
        {
            if (WasCreated)
            {
                LoadSentimentsList();
            }
            else
            {
                ShowErrorMessageInCreate(SentimentAlreadyExistErrorMessage);
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
                LstSentiments.Items.Remove(LstSentiments.SelectedItem); //TODO: delete and update with the result if it was deleted or not
                ActualizeSentimentsList(true);
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

        private void ShowErrorMessageInDelete(String ErrorMessage)
        {
            LblErrorMessageNotSelectedSentiment.Text = ErrorMessage;
        }
    }
}
