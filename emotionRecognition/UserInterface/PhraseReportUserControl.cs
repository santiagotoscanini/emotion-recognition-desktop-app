using BusinessLogic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class PhraseReportUserControl : UserControl
    {
        private const string NoPhrasesRegister = "No hay frases registradas";
        private BusinessLogicController controller;

        public PhraseReportUserControl(Repository repository)
        {
            InitializeComponent();
            this.controller = new BusinessLogicController(repository);
            LoadPhrasesReport();
        }

        private void LoadPhrasesReport()
        {
            controller.AnalizePhrases();
            foreach (Phrase phrase in controller.GetPhrases())
            {
                GrdReport.Rows.Add(
                    phrase.Text,
                    phrase.CreationDate,
                    phrase.Entity == null ? null:phrase.Entity.ToString(),
                    phrase.GetStringFromPhraseState());
            }
        }
    }
}
