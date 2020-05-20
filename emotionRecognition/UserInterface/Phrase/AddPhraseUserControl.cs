using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddPhraseUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public AddPhraseUserControl(Repository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
            OnRefresh(ApplicationState.REGISTER_A_PHRASE);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            PnlPhrases.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.REGISTER_A_PHRASE:
                    PnlPhrases.Controls.Add(new NewPhraseUserControl(controller.Repository));
                    break;
                case ApplicationState.PHRASE_REPORT:
                    PnlPhrases.Controls.Add(new PhraseReportUserControl(controller.Repository));
                    break;
            }

        }

        private void BtnAddPhrase_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.REGISTER_A_PHRASE);
        }

        private void BtnPhraseReport_Click(object sender, EventArgs e)
        {
            OnRefresh(ApplicationState.PHRASE_REPORT);
        }
    }
}
