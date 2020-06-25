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
        }

        private void ShowAuthorPercentageOfPositiveSentiments(Author author)
        {
            int PercentageOfPositiveSentiments = author.NumberOfPhrases != 0 ? (author.NumberOfPositivePhrases / author.NumberOfPhrases) * 100 : 0;
            ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, PercentageOfPositiveSentiments);
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
        }

        private void ShowAuthorPercentageOfNegativeSentiments(Author author)
        {
            int PercentageOfNegativeSentiments = author.NumberOfPhrases != 0 ? (author.NumberOfNegativePhrases / author.NumberOfPhrases) * 100 : 0;
            ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, PercentageOfNegativeSentiments);
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
        }

        private void ShowAuthorAverageOfPhrases(Author author)
        {
            int AverageOfPhrases = author.NumberOfDaysFromFirstPublication != 0 ? 
                author.NumberOfPhrases / author.NumberOfDaysFromFirstPublication : author.NumberOfPhrases;     
           ChtStatisticsAuthors.Series[0].Points.AddXY(author.Username, AverageOfPhrases);
        }
    }
}
