using BusinessLogic;
using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    public partial class MainWindow : Form
    {
        private readonly BusinessLogicController controller;

        public MainWindow(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            PnlMain.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_AN_ALARM:
                    this.PnlMain.Controls.Add(new AlarmUserControl(controller));
                    break;
                case ApplicationState.ADDING_A_ENTITY:
                    this.PnlMain.Controls.Add(new AddEntityUserControl(controller));
                    break;
                case ApplicationState.ADDING_A_PHRASE:
                    this.PnlMain.Controls.Add(new AddPhraseUserControl(controller));
                    break;
                case ApplicationState.ADDING_A_SENTIMENT:
                    this.PnlMain.Controls.Add(new AddSentimentUserControl(controller));
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
