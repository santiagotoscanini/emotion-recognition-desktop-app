using BusinessLogic;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddAlarmUserControl : UserControl
    {
        private const string EmptyText = "";

        private readonly BusinessLogicController controller;  

        public AddAlarmUserControl(Repository repository)
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
            if (CboEntity.Items.Count == 0)
            {
                LblNoEntities.Visible = true;
                CboEntity.Enabled = false;
            }
            else
            {
                CboEntity.SelectedIndex = 0;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            LblDoneMessage.Visible = false;
            if (CheckData())
            {
                CreateAlarm();
            }
        }

        private bool CheckData()
        {
            if(CboEntity.SelectedItem != null && TxtPostsAmount.Text.Length != 0 && int.Parse(TxtPostsAmount.Text) > 0 && TxtTimeFrame.Text.Length != 0
                && int.Parse(TxtTimeFrame.Text) > 0)
            {
                return true;
            }

            ShowErrorMessage();
            return false;
        }

        private void CreateAlarm()
        {
            controller.AddAlarm(CboEntity.Text, RdoPositive.Checked, uint.Parse(TxtPostsAmount.Text), RdoDays.Checked, uint.Parse(TxtTimeFrame.Text));
            ClearFields();
            LblDoneMessage.Visible = true;
        }

        private void ClearFields()
        {
            CboEntity.SelectedIndex = 0;
            TxtPostsAmount.Text = EmptyText;
            TxtTimeFrame.Text = EmptyText;
        }

        private void ShowErrorMessage()
        {
            LblErrorMessage.Visible = true;
        }

        private void HideErrorMessage()
        {
            LblErrorMessage.Visible = false;
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
