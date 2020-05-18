using System;
using System.Windows.Forms;
using UserInterface;

namespace emotionRecognition
{
    public partial class AddPhraseUserControl : UserControl
    {
        public AddPhraseUserControl()
        {
            InitializeComponent();
            OnRefresh(ApplicationState.REGISTER_A_PHRASE);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.PnlPhrases.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.REGISTER_A_PHRASE:
                    this.PnlPhrases.Controls.Add(new NewPhraseUserControl());
                    break;
                case ApplicationState.PHRASE_REPORT:
                    this.PnlPhrases.Controls.Add(new PhraseReportUserControl());
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
