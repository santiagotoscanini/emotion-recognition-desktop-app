using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLogic;
using BusinessLogic.Entities;

namespace UserInterface
{
    public partial class AuthorStatisticsUserControl : UserControl
    {

        BusinessLogicController BusinessLogicController;
        public AuthorStatisticsUserControl(BusinessLogicController BusinessLogicController)
        {
            this.BusinessLogicController = BusinessLogicController;
            InitializeComponent();
            LoadChart();
        }

        private void LoadChartSeries()
        {
            ChtStatisticsAuthors.Series.Add("Frases Positivas");
            ChtStatisticsAuthors.Series.Add("Frases Negativas");
            ChtStatisticsAuthors.Series.Add("Entidades mencionadas");
            ChtStatisticsAuthors.Series.Add("Promedio frases diario");
            ChtStatisticsAuthors.ChartAreas[0].AxisX.Interval = 1;
        }

        private void LoadChart()
        {
            LoadChartSeries();

            foreach(Author author in BusinessLogicController.GetAuthors().Take(10))
            {
                string userName = author.Username;
                ChtStatisticsAuthors.Series[0].Points.AddXY(userName,author.NumberOfPositivePhrases);
                ChtStatisticsAuthors.Series[1].Points.AddXY(userName, author.NumberOfNegativePhrases);
                ChtStatisticsAuthors.Series[2].Points.AddXY(userName, author.NumberOfDistinctEntitiesMentioned);
                ChtStatisticsAuthors.Series[3].Points.AddXY(userName, author.NumberOfPhrases / author.NumberOfDaysFromFirstPublication);
            }
        }
    }
}
