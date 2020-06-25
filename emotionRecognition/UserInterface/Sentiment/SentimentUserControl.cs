using BusinessLogic;
using BusinessLogic.Entities;
using BusinessLogic.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class SentimentUserControl : UserControl
    {
        private const string SentimentAlreadyExistErrorMessage = "Ese sentimiento ya existe";
        private const string NoSentimentsRegisteredErrorMessage = "No hay sentimientos registrados";
        private const string SelectSentimentToDeleteErrorMessage = "Debes seleccionar un sentimiento para poder eliminarlo";
        private const string CanNotSaveEmptyData = "El texto del sentimiento no puede ser vacío";
        private const string CanNotDeleteUsingSentiment = "Ese sentimiento esta siendo utilizado por al menos una frase, no puede ser eliminado";
        private const string EmptyText = "";

        private readonly BusinessLogicController controller;
        private SentimentState state;

        public SentimentUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            state = SentimentState.POSITIVE;
            OnRefresh();
        }

        private void LoadSentimentsList(IEnumerable<Sentiment> sentimentList)
        {
            ClearList();
            foreach (Sentiment sentiment in sentimentList)
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
                ShowErrorMessageInList(NoSentimentsRegisteredErrorMessage);
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
            AddSentimentInTheList();
            ClearFields();
        }

        private void HideErrorMessages()
        {
            LblErrorMessageEmptyData.Text = EmptyText;
            LblErrorMessageNotSelectedSentiment.Text = EmptyText;
        }

        private void AddSentimentInTheList()
        {
            if (CheckDataToCreate())
            {
                string sentimentText = TxtNewSentiment.Text;
                
                bool wasCreated = state == SentimentState.POSITIVE ?
                    controller.AddPositiveSentiment(sentimentText):
                    controller.AddNegativeSentiment(sentimentText);

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
               OnRefresh();
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

        private void RdoPositive_CheckedChanged(object sender, EventArgs e)
        {
            state = SentimentState.POSITIVE;
            OnRefresh();
        }

        private void RdoNegative_CheckedChanged(object sender, EventArgs e)
        {
            state = SentimentState.NEGATIVE;
            OnRefresh();
        }

        private void OnRefresh()
        {
            switch (state)
            {
                case SentimentState.POSITIVE:
                    LoadSentimentsList(controller.GetPositiveSentiments());
                    break;
                case SentimentState.NEGATIVE:
                    LoadSentimentsList(controller.GetNegativeSentiments());
                    break;
            }
        }
    }
}
