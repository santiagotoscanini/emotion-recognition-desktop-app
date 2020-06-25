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
            foreach (Phrase phrase in controller.GetPhrases())
            {
                GrdReport.Rows.Add(
                    phrase.Text,
                    phrase.Author.Username,
                    phrase.CreationDate,
                    phrase.Entity != null ? phrase.Entity.ToString() : "",
                    phrase.GetStringFromPhraseState());
            }
        }
    }
}
