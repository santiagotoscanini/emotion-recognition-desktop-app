using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmConfigurationUserControl : UserControl
    {
        private const string EmptyText = "";
        private const string CompleteAllFieldsErrorMessage = "Asegurate de completar todos los campos";

        public AlarmConfigurationUserControl()
        {
            InitializeComponent();
            this.Controls.Add(TxtTimeFrame);
        }

        private void BtnSafe_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            if (CheckData())
            {
                CreateAlarm();
            }
        }

        private bool CheckData()
        {
            if(CboEntity.SelectedItem != null && TxtPostsAmount.TextLength > 0 
                && TxtTimeFrame.TextLength > 0)
            {
                return true;
            }

            ShowErrorMessage(CompleteAllFieldsErrorMessage);
            return false;
        }

        private void CreateAlarm()
        {
            //TODO: here we create the alarm
            ClearFields();
        }

        private void ClearFields()
        {
            CboEntity.SelectedItem = null;
            TxtPostsAmount.Text = EmptyText;
            TxtTimeFrame.Text = EmptyText;
        }

        private void ShowErrorMessage(String ErrorMessage)
        {
            LblErrorMassage.Text = ErrorMessage;
        }

        private void HideErrorMessage()
        {
            LblErrorMassage.Text = EmptyText;
        }
    }
}
