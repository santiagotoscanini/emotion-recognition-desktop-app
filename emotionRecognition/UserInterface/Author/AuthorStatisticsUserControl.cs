using System.Collections;
using System.Collections.Generic;
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
        private const string PositivePhrases = "Porcentaje de frases Positivas";
        private const string NegativePhrases = "Porcentaje de frases Negativas";
        private const string EntitiesMentioned = "Entidades mencionadas";
        private const string PercentagePhrases = "Promedio frases diario";

        public AuthorStatisticsUserControl(BusinessLogicController businessLogicController)
        {
            this.BusinessLogicController = businessLogicController;
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
            List<Author> authors = BusinessLogicController.GetAuthors().OrderBy(author => author.NumberOfPhrases != 0 ?
                (author.NumberOfPositivePhrases / author.NumberOfPhrases) * 100 : 0).ToList();
            foreach (Author author in authors.Take(10).Reverse())
            {
                ShowAuthorPercentageOfPositiveSentiments(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorPercentageOfPositiveSentiments(Author author)
        {
            int PercentageOfPositivePhrases = author.PercentageOfPositivePhrases();
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

            List<Author> authors = BusinessLogicController.GetAuthors().OrderBy(author => author.NumberOfPhrases != 0 ?
                (author.NumberOfNegativePhrases / author.NumberOfPhrases) * 100 : 0).ToList();
            foreach (Author author in authors.Take(10).Reverse())
            {
                ShowAuthorPercentageOfNegativeSentiments(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorPercentageOfNegativeSentiments(Author author)
        {
            int PercentageOfNegativePhrases = author.PercentageOfNegativePhrases();
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
                .OrderBy(author => (author.NumberOfDaysFromFirstPublication != 0 ?
                author.NumberOfPhrases / author.NumberOfDaysFromFirstPublication : author.NumberOfPhrases)).ToList();
            foreach (Author author in BusinessLogicController.GetAuthors().Take(10).Reverse())
            {
                ShowAuthorAverageOfPhrases(author);
            }

            ChtStatisticsAuthors.ChartAreas[0].RecalculateAxesScale();
        }

        private void ShowAuthorAverageOfPhrases(Author author)
        {
            int AverageOfPhrases = author.AvgOfPhrasesPerDay();
           ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, AverageOfPhrases);
        }
    }
}
