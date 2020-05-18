using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmReportUserControl : UserControl
    {
        private const string NoAlarmRegisteredErrorMessage = "No hay alarmas registradas";
        public AlarmReportUserControl()
        {
            InitializeComponent();
            LoadAlarms();
        }

        private void LoadAlarms()
        {
            //TODO:  list the alarms 
            ValidateIfIsEmpty();
        }
        private void ValidateIfIsEmpty()
        {
            if (LstAlarms.Items.Count == 0)
            {
                ShowErrorMessage();
            }
        }

        private void ShowErrorMessage()
        {
            LblErrorMessage.Text = NoAlarmRegisteredErrorMessage;
            LblErrorMessage.Visible = true;
        }
    }
}
