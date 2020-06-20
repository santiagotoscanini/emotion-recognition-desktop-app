using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AlarmUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AlarmUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlAlarm.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.CONFIG_AN_ALARM:
                    PnlAlarm.Controls.Add(new AddAlarmUserControl(controller));
                    break;
                case ApplicationState.ALARMS_REPORT:
                    PnlAlarm.Controls.Add(new AlarmReportUserControl(controller));
                    break;
            }

        }

        private void AlarmConfigButton_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }

        private void BtnAlarmReport_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.ALARMS_REPORT);
        }
    }
}
