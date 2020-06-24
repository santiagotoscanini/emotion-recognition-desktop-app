using BusinessLogic;
using BusinessLogic.Entities;
using BusinessLogic.Enums;
using emotionRecognition;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AlarmReportUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AlarmReportUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            LoadAlarms(AlarmReportState.VIEW_REPORT_ENTITIES);
        }

        private void LoadAlarms(AlarmReportState reportState)
        {
            GrdAlarms.Rows.Clear();
            switch (reportState)
            {
                case AlarmReportState.VIEW_REPORT_ENTITIES:
                    Entidad.HeaderText = "Entidad";

                    foreach (EntityTimeLapseAlarm alarm in controller.GetEntityAlarmsChecked())
                    {
                        AddEntityAlarmRow(
                         alarm.Entity.Name,
                         alarm.TimeSearchMethodType.Equals(TimeSearchMethodType.DAYS),
                         alarm.QuantityOfTimeToSearchBack,
                         alarm.AlarmPosibleState.Equals(AlarmPosibleState.POSITIVE),
                         alarm.QuantityOfSentimentsNeeded,
                         alarm.IsActivated
                         );
                    }

                    break;
                case AlarmReportState.VIEW_REPORT_AUTHORS:
                    Entidad.HeaderText = "Autores";

                    foreach (AuthorTimeLapseAlarm alarm in controller.GetAuthorAlarmsChecked())
                    {
                        AddAuthorAlarmRow(
                         alarm.ActivatingAuthors,
                         alarm.TimeSearchMethodType.Equals(TimeSearchMethodType.DAYS),
                         alarm.QuantityOfTimeToSearchBack,
                         alarm.AlarmPosibleState.Equals(AlarmPosibleState.POSITIVE),
                         alarm.QuantityOfSentimentsNeeded,
                         alarm.IsActivated
                         );
                    }

                    break;
            }

            //    this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //    this.SearchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //    this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //    this.SentimentToDetect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //    this.NumberOfSentimentsNeeded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //    this.IsActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();

            //    this.GrdAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.Entidad,
            //this.SearchType,
            //this.Time,
            //this.SentimentToDetect,
            //this.NumberOfSentimentsNeeded,
            //this.IsActivated});

        }

        private void AddAuthorAlarmRow(ICollection<Author> authors, bool searchMethodDays, int timeToSearch, bool detectPositives, int sentimentsNeeded, bool isActivated)
        {
            string authorsToString = "";

            foreach (Author author in authors){
                authorsToString += author.Username.ToString() + "\n";
            }
            
            GrdAlarms.Rows.Add(
                authorsToString,
                searchMethodDays ? "Dias" : "Horas",
                timeToSearch,
                detectPositives ? "Positivo" : "Negativo",
                sentimentsNeeded,
                isActivated
                );
        }

        private void AddEntityAlarmRow(string entityName, bool searchMethodDays, int timeToSearch, bool detectPositives, int sentimentsNeeded, bool isActivated)
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

        private void RdoAlarmEntities_CheckedChanged(object sender, System.EventArgs e)
        {
            LoadAlarms(AlarmReportState.VIEW_REPORT_ENTITIES);
        }

        private void RdoAlarmAutores_CheckedChanged(object sender, System.EventArgs e)
        {
            LoadAlarms(AlarmReportState.VIEW_REPORT_AUTHORS);
        }
    }
}
