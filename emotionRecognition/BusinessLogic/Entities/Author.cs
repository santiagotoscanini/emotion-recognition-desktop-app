using System;
using System.Collections.Generic;

namespace BusinessLogic.Entities
{
    public class Author
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        public int NumberOfPhrases { get; set; }
        public int NumberOfPositivePhrases { get; set; }
        public int NumberOfNegativePhrases { get; set; }
        public int NumberOfDistinctEntitiesMentioned { get; set; }
        public int NumberOfDaysFromFirstPublication { get; set; }

        public ICollection<AuthorTimeLapseAlarm> AuthorTimeLapseAlarms { get; set; }


        public Author() { }

        public int PercentageOfNegativePhrases()
        {
            float percentage = NumberOfPhrases != 0 ? (float)NumberOfNegativePhrases / (float)NumberOfPhrases : 0;
            int PercentageOfNegativeSentiments = (int)(percentage * 100);
            return PercentageOfNegativeSentiments;
        }

        public int PercentageOfPositivePhrases()
        {
            float percentage = NumberOfPhrases != 0 ? (float)NumberOfPositivePhrases / (float)NumberOfPhrases : 0;
            int PercentageOfPositiveSentiments = (int)(percentage * 100);
            return PercentageOfPositiveSentiments;
        }

        public int AvgOfPhrasesPerDay()
        {
            int AverageOfPhrases = NumberOfDaysFromFirstPublication != 0 ?
                NumberOfPhrases / NumberOfDaysFromFirstPublication : NumberOfPhrases;
            return AverageOfPhrases;
        }

        public void AnalyzeAuthorMetrics(IEnumerable<Phrase> phrases)
        {
            int numberOfPhrases = 0;
            int numberOfPositivePhrases = 0;
            int numberOfNegativePhrases = 0;
            DateTime dateOfFirstPhrase = DateTime.Now;
            HashSet<Entity> distinctEntitiesUsed = new HashSet<Entity>();

            foreach (Phrase phrase in phrases)
            {
                if (phrase.Author.Username.Equals(Username))
                {
                    numberOfPhrases++;
                    if (phrase.Entity != null) distinctEntitiesUsed.Add(phrase.Entity);
                    if (phrase.CreationDate < dateOfFirstPhrase) dateOfFirstPhrase = phrase.CreationDate;
                    if (phrase.PhraseState > 0) numberOfPositivePhrases++;
                    else if (phrase.PhraseState < 0) numberOfNegativePhrases++;
                }
            }

            NumberOfDistinctEntitiesMentioned = distinctEntitiesUsed.Count;
            NumberOfDaysFromFirstPublication = (DateTime.Now - dateOfFirstPhrase).Days;
            NumberOfPhrases = numberOfPhrases;
            NumberOfPositivePhrases = numberOfPositivePhrases;
            NumberOfNegativePhrases = numberOfNegativePhrases;
            AuthorTimeLapseAlarms = new HashSet<AuthorTimeLapseAlarm>();
        }
    }
}
