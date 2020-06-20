using BusinessLogic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PhraseReportUserControl : UserControl
    {
        private readonly BusinessLogicController controller;

        public PhraseReportUserControl(IRepository repository)
        {
            InitializeComponent();
            controller = new BusinessLogicController(repository);
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
