using BusinessLogic;
using BusinessLogic.Entities;
using emotionRecognition;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AddAlarmUserControl : UserControl
    {
        private readonly BusinessLogicController controller;
        private AlarmCreateState alarmCreateState;

        public AddAlarmUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            LoadEntities();
            OnRefresh(AlarmCreateState.ADD_ALARM_ENTITIES);
        }

        private void OnRefresh(AlarmCreateState state)
        {
            alarmCreateState = state;
            switch (alarmCreateState)
            {
                case AlarmCreateState.ADD_ALARM_ENTITIES:
                    //LblNoEntities.Visible = true;
                    CboEntity.Visible = true;
                    LoadEntities();
                    break;
                case AlarmCreateState.ADD_ALARM_AUTHORS:
                    LblNoEntities.Visible = false;
                    CboEntity.Visible = false;
                    BtnSave.Enabled = true;
                    break;
            }
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
            if (alarmCreateState == AlarmCreateState.ADD_ALARM_AUTHORS || CboEntity.SelectedItem != null)
            {
                return true;
            }

            ShowErrorMessage();
            return false;
        }

        private void CreateAlarm()
        {
            if (alarmCreateState == AlarmCreateState.ADD_ALARM_ENTITIES)
            {
                controller.AddEntityAlarm(CboEntity.Text, RdoDays.Checked, int.Parse(NudPostQuantity.Text), RdoPositive.Checked, int.Parse(NudTimeLapse.Text));
             }
            else
            {
                controller.AddAuthorAlarm(RdoDays.Checked, int.Parse(NudPostQuantity.Text), RdoPositive.Checked, int.Parse(NudTimeLapse.Text));
            }

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

        private void RdoAlarmEntities_CheckedChanged(object sender, EventArgs e)
        {
            OnRefresh(AlarmCreateState.ADD_ALARM_ENTITIES);
        }

        private void RdoAlarmAutores_CheckedChanged(object sender, EventArgs e)
        {
            OnRefresh(AlarmCreateState.ADD_ALARM_AUTHORS);
        }
    }
}
