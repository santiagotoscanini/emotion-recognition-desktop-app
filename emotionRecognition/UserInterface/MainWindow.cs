using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlMain.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_AN_ALARM:
                    this.PnlMain.Controls.Add(new AddAlarmUserControl());
                    break;
                case ApplicationState.ADDING_A_ENTITY:
                    this.PnlMain.Controls.Add(new AddEntityUserControl());
                    break;
                case ApplicationState.ADDING_A_PHRASE:
                    this.PnlMain.Controls.Add(new AddPhraseUserControl());
                    break;
                case ApplicationState.ADDING_A_SENTIMENT:
                    this.PnlMain.Controls.Add(new AddSentimentUserControl());
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
