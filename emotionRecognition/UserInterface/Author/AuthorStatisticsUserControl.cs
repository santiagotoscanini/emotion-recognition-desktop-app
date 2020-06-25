using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Entities;

namespace UserInterface
{
    public partial class AuthorStatisticsUserControl : UserControl
    {

        BusinessLogicController BusinessLogicController;
        private const string PositivePhrases = "Porcentaje de frases Positivas";
        private const string NegativePhrases = "Porcentaje de frases Negativas";
        private const string EntitiesMentioned = "Cantidad de distintas entidades mencionadas";
        private const string PercentagePhrases = "Promedio de frases por día";

        public AuthorStatisticsUserControl(BusinessLogicController businessLogicController)
        {
            BusinessLogicController = businessLogicController;
            InitializeComponent();
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            ChtStatisticsAuthors.ChartAreas[0].AxisX.Interval = 1;
            RboPositiveSentiment.Checked = true;
            SetPositiveSentimentsData();
        }

        private void SetPositiveSentimentsData()
        {
            ChtStatisticsAuthors.Series.Clear();
            ChtStatisticsAuthors.Series.Add(PositivePhrases);
            List<Author> authors = BusinessLogicController.GetAuthors().OrderBy(author => author.GetPercentageOfPositivePhrases()).ToList();
            foreach (Author author in authors.Take(10).Reverse())
            {
                ShowAuthorPercentageOfPositiveSentiments(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorPercentageOfPositiveSentiments(Author author)
        {
            int PercentageOfPositivePhrases = author.GetPercentageOfPositivePhrases();
            ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, PercentageOfPositivePhrases);
        }

        private void RboPositiveSentiment_CheckedChanged(object sender, System.EventArgs e)
        {
            SetPositiveSentimentsData();
        }

        private void RboNegativeSentiments_CheckedChanged(object sender, System.EventArgs e)
        {
            SetNegativeSentimentsData();
        }

        private void SetNegativeSentimentsData()
        {
            ChtStatisticsAuthors.Series.Clear();
            ChtStatisticsAuthors.Series.Add(NegativePhrases);

            List<Author> authors = BusinessLogicController.GetAuthors().OrderBy(author => author.GetPercentageOfNegativePhrases()).ToList();
            foreach (Author author in authors.Take(10).Reverse())
            {
                ShowAuthorPercentageOfNegativeSentiments(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorPercentageOfNegativeSentiments(Author author)
        {
            int PercentageOfNegativePhrases = author.GetPercentageOfNegativePhrases();
            ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, PercentageOfNegativePhrases);
        }

        private void RboNamedEntities_CheckedChanged(object sender, System.EventArgs e)
        {
            SetMentionedEntitiesData();
        }

        private void SetMentionedEntitiesData()
        {
            ChtStatisticsAuthors.Series.Clear();
            ChtStatisticsAuthors.Series.Add(EntitiesMentioned);

            List<Author> authors = BusinessLogicController.GetAuthors().OrderBy(author => author.NumberOfDistinctEntitiesMentioned).ToList();
            foreach (Author author in authors.Take(10).Reverse())
            {
                ShowAuthorNumberOfMentionedEntities(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorNumberOfMentionedEntities(Author author)
        {
            ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, author.NumberOfDistinctEntitiesMentioned);
        }

        private void RboPercentagePhrases_CheckedChanged(object sender, System.EventArgs e)
        {
            SetDailyPhrasesData();
        }

        private void SetDailyPhrasesData()
        {
            ChtStatisticsAuthors.Series.Clear();
            ChtStatisticsAuthors.Series.Add(PercentagePhrases);

            List<Author> authors = BusinessLogicController.GetAuthors()
                .OrderBy(author => author.GetAvgOfPhrasesPerDay()).ToList();
            foreach (Author author in BusinessLogicController.GetAuthors().Take(10).Reverse())
            {
                ShowAuthorAverageOfPhrases(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorAverageOfPhrases(Author author)
        {
            int AverageOfPhrases = author.GetAvgOfPhrasesPerDay();
           ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, AverageOfPhrases);
        }
    }
}
