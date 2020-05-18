using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddAlarmUserControl : UserControl
    {
        public AddAlarmUserControl()
        {
            InitializeComponent();
            this.OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlAlarm.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.CONFIG_AN_ALARM:
                    this.PnlAlarm.Controls.Add(new AlarmConfigurationUserControl());
                    break;
                case ApplicationState.ALARMS_REPORT:
                    this.PnlAlarm.Controls.Add(new AlarmReportUserControl());
                    break;
            }

        }

        private void BtnAlarmReportButton_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ALARMS_REPORT);
        }

        private void AlarmConfigButton_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.CONFIG_AN_ALARM);
        }
    }
}
