using BusinessLogic;
using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    public partial class MainWindow : Form
    {
        private BusinessLogicController controller;

        public MainWindow(Repository repository)
        {
            InitializeComponent();
            this.controller = new BusinessLogicController(repository);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlMain.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_AN_ALARM:
                    this.PnlMain.Controls.Add(new AlarmUserControl(controller.Repository));
                    break;
                case ApplicationState.ADDING_A_ENTITY:
                    this.PnlMain.Controls.Add(new AddEntityUserControl(controller.Repository));
                    break;
                case ApplicationState.ADDING_A_PHRASE:
                    this.PnlMain.Controls.Add(new AddPhraseUserControl(controller.Repository));
                    break;
                case ApplicationState.ADDING_A_SENTIMENT:
                    this.PnlMain.Controls.Add(new AddSentimentUserControl(controller.Repository));
                    break;
            }
        }

        private void BtnSentiments_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_A_SENTIMENT);
        }

        private void BtnPhrases_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_A_PHRASE);
        }

        private void BtnEntities_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_A_ENTITY);
        }

        private void BtnAlarms_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_AN_ALARM);
        }
    }
}
