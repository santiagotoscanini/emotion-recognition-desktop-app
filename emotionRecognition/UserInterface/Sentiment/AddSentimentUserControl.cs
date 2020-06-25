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
            PnlSentiments.Controls.Add(new SentimentUserControl(controller));
        }
    }
}
