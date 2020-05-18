using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddSentimentUserControl : UserControl
    {
        public AddSentimentUserControl()
        {
            InitializeComponent();
            OnRefresh(ApplicationState.ADDING_POSITIVE_SENTIMENT);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlSentiments.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.ADDING_POSITIVE_SENTIMENT:
                    PnlSentiments.Controls.Add(new PositiveSentimentUserControl());
                    break;
                case ApplicationState.ADDING_NEGATIVE_SENTIMENT:
                    this.PnlSentiments.Controls.Add(new NegativeSentimentUserControl());
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
