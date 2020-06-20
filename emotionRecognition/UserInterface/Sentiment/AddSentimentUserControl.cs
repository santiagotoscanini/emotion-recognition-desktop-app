using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddSentimentUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AddSentimentUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            OnRefresh(ApplicationState.ADDING_POSITIVE_SENTIMENT);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            PnlSentiments.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_POSITIVE_SENTIMENT:
                    PnlSentiments.Controls.Add(new PositiveSentimentUserControl(controller));
                    break;
                case ApplicationState.ADDING_NEGATIVE_SENTIMENT:
                    PnlSentiments.Controls.Add(new NegativeSentimentUserControl(controller));
                    break;
            }

        }

        private void RbtNegative_CheckedChanged(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.ADDING_NEGATIVE_SENTIMENT);
        }

        private void RbtPositive_CheckedChanged(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.ADDING_POSITIVE_SENTIMENT);
        }

    }
}
