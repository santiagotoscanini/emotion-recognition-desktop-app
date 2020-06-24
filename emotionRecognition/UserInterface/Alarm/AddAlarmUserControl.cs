using BusinessLogic;
using BusinessLogic.Entities;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddAlarmUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AddAlarmUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
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
                BtnSave.Enabled = false;
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
            if (CboEntity.SelectedItem != null)
            {
                return true;
            }

            ShowErrorMessage();
            return false;
        }

        private void CreateAlarm()
        {
            controller.AddEntityAlarm(CboEntity.Text, RdoDays.Checked, uint.Parse(NudPostQuantity.Text), RdoPositive.Checked, uint.Parse(NudTimeLapse.Text));
            ClearFields();
            LblDoneMessage.Visible = true;
        }

        private void ClearFields()
        {
            CboEntity.SelectedIndex = 0;
            NudTimeLapse.Value = 1;
            NudPostQuantity.Value = 1;
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
