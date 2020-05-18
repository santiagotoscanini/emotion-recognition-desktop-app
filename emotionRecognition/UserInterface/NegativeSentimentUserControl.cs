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

        public NegativeSentimentUserControl()
        {
            InitializeComponent();
            LoadSentimentsList();
        }

        private void LoadSentimentsList()
        {
            //TODO: here we load the registered negative sentiments
            ValidateIfIsEmpty();
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
                //TODO: save and update with the result if it was saved or not
                LstSentiments.Items.Add(TxtNewSentiment.Text);
                ActualizeSentimentsList(true);
            }
        }

        private bool CheckData()
        {
            if (TxtNewSentiment.Text.Length > 0)
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

        private void ActualizeSentimentsList(bool WasCreated)
        {
            if (WasCreated)
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

            ShowErrorMessageInDelete(SelectDataToDelete);
            return false;
        }

        private void ShowErrorMessageInDelete(string ErrorMessage)
        {
            LblErrorMessageNotSelectedItem.Text = ErrorMessage;
        }
    }
}
