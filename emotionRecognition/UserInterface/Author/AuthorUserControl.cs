using System;
using System.Windows.Forms;
using BusinessLogic;
using emotionRecognition;

namespace UserInterface
{
    public partial class AuthorUserControl : UserControl
    {
        private BusinessLogicController controller;
        private string username;

        public AuthorUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            OnRefresh(ApplicationState.ADDING_AN_AUTHOR);
        }

        public void ClearPanel()
        {
            PnlAlarm.Controls.Clear();
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            ClearPanel();

            switch (applicationState)
            {
                case ApplicationState.ADDING_AN_AUTHOR:
                    PnlAlarm.Controls.Add(new AddAuthorUserControl(controller, username, this));
                    this.username = null;
                    break;
                case ApplicationState.AUTHOR_REPORT:
                    PnlAlarm.Controls.Add(new AuthorReportUserControl(controller, this));
                    break;
                case ApplicationState.AUTHOR_STATISTICS:
                    PnlAlarm.Controls.Add(new AuthorStatisticsUserControl(controller));
                    break;
            }
        }

        private void BtnAuthorAdd_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.ADDING_AN_AUTHOR);
        }

        private void BtnAuthorReport_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.AUTHOR_REPORT);
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.AUTHOR_STATISTICS);
        }
        
        public void OnModify(string username)
        {
            this.username = username;
            OnRefresh(ApplicationState.ADDING_AN_AUTHOR);
        }

        public void getBackToReport()
        {
            OnRefresh(ApplicationState.AUTHOR_REPORT);
        }
    }
}
