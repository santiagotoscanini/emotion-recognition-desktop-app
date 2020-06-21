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

        public int NumberOfPhrases { get;  set; }
        public int NumberOfPositivePhrases { get; set; }
        public int NumberOfNegativePhrases { get; set; }
        public int NumberOfDistinctEntitiesMentioned { get; set; }
        public int NumberOfDaysFromFirstPublication { get; set; }


        public Author() { }

        public void Analyze(IEnumerable<Phrase> phrases, IEnumerable<Entity> entities)
        {
            int numberOfPhrases = 0;
            int numberOfPositivePhrases = 0;
            int numberOfNegativePhrases = 0;

            DateTime dateOfFirstPhrase = DateTime.Today;
            HashSet<Entity> distinctEntitiesUsed = new HashSet<Entity>();

            foreach (Phrase phrase in phrases)
            {
                if (phrase.Author.Username.Equals(Username))
                {
                    distinctEntitiesUsed.Add(phrase.Entity);
                    numberOfPhrases++;
                    if (phrase.PhraseState > 0) numberOfPositivePhrases++;
                    else if (phrase.PhraseState < 0) numberOfNegativePhrases++;

                    if (phrase.CreationDate < dateOfFirstPhrase) dateOfFirstPhrase= phrase.CreationDate;
                }
            }

            NumberOfDistinctEntitiesMentioned = distinctEntitiesUsed.Count;
            NumberOfDaysFromFirstPublication = (DateTime.Today - dateOfFirstPhrase).Days;
            NumberOfPhrases = numberOfPhrases;
            NumberOfPositivePhrases = numberOfPositivePhrases;
            NumberOfNegativePhrases = numberOfNegativePhrases;
        }
    }
}
