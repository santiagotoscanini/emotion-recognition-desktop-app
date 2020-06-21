using BusinessLogic;
using BusinessLogic.Entities;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PhraseReportUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public PhraseReportUserControl(BusinessLogicController controller)
        {
            InitializeComponent();
            this.controller = controller;
            LoadPhrasesReport();
        }

        private void LoadPhrasesReport()
        {
            controller.AnalyzePhrases();
            foreach (Phrase phrase in controller.GetPhrases())
            {
                GrdReport.Rows.Add(
                    phrase.Text,
                    phrase.CreationDate,
                     phrase.Entity.ToString() ?? null,
                    phrase.GetStringFromPhraseState());
            }
        }
    }
}
