using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddSentimentUserControl : UserControl
    {
        private BusinessLogicController controller;

        public AddSentimentUserControl(Repository repository)
        {
            InitializeComponent();
            this.controller = new BusinessLogicController(repository);
            OnRefresh(ApplicationState.ADDING_POSITIVE_SENTIMENT);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlSentiments.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_POSITIVE_SENTIMENT:
                    PnlSentiments.Controls.Add(new PositiveSentimentUserControl(controller.Repository));
                    break;
                case ApplicationState.ADDING_NEGATIVE_SENTIMENT:
                    this.PnlSentiments.Controls.Add(new NegativeSentimentUserControl(controller.Repository));
                    break;
            }

        }

        private void BtnPositive_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_POSITIVE_SENTIMENT);
        }

        private void BtnNegative_Click(object sender, EventArgs e)
        {
            this.OnRefresh(ApplicationState.ADDING_NEGATIVE_SENTIMENT);
        }
    }
}
