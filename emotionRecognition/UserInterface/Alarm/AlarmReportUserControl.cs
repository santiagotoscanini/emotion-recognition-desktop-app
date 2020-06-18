using BusinessLogic;
using BusinessLogic.Enums;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmReportUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AlarmReportUserControl(Repository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            LoadAlarms();
        }

        private void LoadAlarms()
        {
            foreach(TimeLapseAlarm alarm in controller.GetAlarmsChecked())
            {
                           AddRow(
                    alarm.Entity.Name, 
                    alarm.TimeSearchMethodType.Equals(TimeSearchMethodType.DAYS),
                    alarm.QuantityOfTimeToSearchBack,
                    alarm.AlarmPosibleState.Equals(AlarmPosibleState.POSITIVE),
                    alarm.QuantityOfSentimentsNeeded,
                    alarm.IsActivated
                    );
            }
        }

        private void AddRow(string entityName, bool searchMethodDays, uint timeToSearch, bool detectPositives, uint sentimentsNeeded, bool isActivated)
        {
            GrdAlarms.Rows.Add(
                entityName,
                searchMethodDays ? "Dias" : "Horas",
                timeToSearch,
                detectPositives ? "Positivo" : "Negativo",
                sentimentsNeeded,
                isActivated
                );
        }
    }
}
