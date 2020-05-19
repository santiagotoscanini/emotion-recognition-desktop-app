using BusinessLogic;
using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddPhraseUserControl : UserControl
    {
        private Repository repository;

        public AddPhraseUserControl(Repository repository)
        {
            InitializeComponent();
            this.repository = repository;
            OnRefresh(ApplicationState.REGISTER_A_PHRASE);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlPhrases.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.REGISTER_A_PHRASE:
                    this.PnlPhrases.Controls.Add(new NewPhraseUserControl(this.repository));
                    break;
                case ApplicationState.PHRASE_REPORT:
                    this.PnlPhrases.Controls.Add(new PhraseReportUserControl(this.repository));
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
