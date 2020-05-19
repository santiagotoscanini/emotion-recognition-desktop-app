using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddAlarmUserControl : UserControl
    {
        private BusinessLogicController controller;

        public AddAlarmUserControl(Repository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            this.OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlAlarm.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.CONFIG_AN_ALARM:
                    this.PnlAlarm.Controls.Add(new AlarmConfigurationUserControl(controller.Repository));
                    break;
                case ApplicationState.ALARMS_REPORT:
                    this.PnlAlarm.Controls.Add(new AlarmReportUserControl(controller.Repository));
                    break;
            }

        }

        private void AlarmConfigButton_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }

        private void BtnAlarmReport_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ALARMS_REPORT);
        }
    }
}
