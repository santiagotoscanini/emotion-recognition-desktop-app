using System;
using System.Windows.Forms;
using BusinessLogic;
using emotionRecognition;

namespace UserInterface
{
    public partial class AuthorUserControl : UserControl
    {
        private BusinessLogicController controller;
        private string authorUsername;

        public AuthorUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            OnRefresh(ApplicationState.ADDING_AN_AUTHOR);
        }

        public void ClearPanel()
        {
            this.PnlAlarm.Controls.Clear();
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.ClearPanel();

            switch (applicationState)
            {
                case ApplicationState.ADDING_AN_AUTHOR:
                    PnlAlarm.Controls.Add(new AddAuthorUserControl(controller, authorUsername));
                    break;
                case ApplicationState.AUTHOR_REPORT:
                    PnlAlarm.Controls.Add(new AuthorReportUserControl(controller, this));
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

        internal void ModifiyAuthor(string authorUsername)
        {
            this.authorUsername = authorUsername;
            OnRefresh(ApplicationState.ADDING_AN_AUTHOR);
        }
    }
}
