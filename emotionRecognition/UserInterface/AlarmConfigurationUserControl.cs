using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmConfigurationUserControl : UserControl
    {
        private const string EmptyText = "";
        private const string CompleteAllFieldsErrorMessage = "Asegurate de completar todos los campos";
        private BusinessLogicController controller;

        public AlarmConfigurationUserControl(Repository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            LoadEntities();
        }

        private void LoadEntities()
        {
            foreach (Entity entity in controller.GetEntities())
            {
                CboEntity.Items.Add(entity.Name);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
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
            controller.AddAlarm(CboEntity.Text, RdoPositive.Checked, uint.Parse(TxtPostsAmount.Text), RdoDays.Checked, uint.Parse(TxtTimeFrame.Text));
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

        private void AlarmConfigurationUserControl_Load(object sender, EventArgs e)
        {

        }

        private void RdoPositive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdoNegative_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtPostsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTimeFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
