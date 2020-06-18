using System;
using System.Collections.Generic;
using BusinessLogic.Enums;

namespace BusinessLogic 
{
    public class Phrase
    {
        public int Id { get; set; } 
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public Entity Entity { get; set; }
        public PhraseState PhraseState { get; set; }

        public Phrase() { }

        public Phrase(string text, IEnumerable<Sentiment> sentiments, IEnumerable<Entity> entities, DateTime creationDate)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Text cannot be null or empty", "text");
            }
            if(sentiments == null)
            {
                throw new ArgumentNullException("sentiments", "Sentiments cannot be null");
            }
            if (entities == null)
            {
                throw new ArgumentNullException("entities", "Entities cannot be null");
            }

            Text = text;
            CreationDate = creationDate;
            Analyze(sentiments, entities);
        }

        public void Analyze(IEnumerable<Sentiment> sentiments, IEnumerable<Entity> entities)
        {
            Entity = GetEntity(entities);
            PhraseState = GetPhraseState(sentiments);
        }

        private Entity GetEntity(IEnumerable<Entity> entities)
        {
            int lowestIndexOfPhrase = Text.Length;
            Entity entityInLowestIndex = null;
            foreach (Entity entity in entities)
            {
                int actualIndex = Text.IndexOf(entity.Name);
                if (actualIndex != -1 && actualIndex < lowestIndexOfPhrase)
                {
                    lowestIndexOfPhrase = actualIndex;
                    entityInLowestIndex = entity;
                }
            }

            return entityInLowestIndex;
        }

        private PhraseState GetPhraseState(IEnumerable<Sentiment> sentiments)
        {
            int actualSumOfSentiments = 0;

            foreach (Sentiment sentiment in sentiments)
            {
                if (Text.ToLower().Contains(sentiment.Text))
                {
                    int weightOfSentiment = (int)sentiment.State;
                    if (IsNeutral(actualSumOfSentiments, weightOfSentiment))
                    {
                        actualSumOfSentiments = 0;
                        break;
                    }
                    actualSumOfSentiments += weightOfSentiment;
                }
            }

            return GetPhraseStateFromNumber(actualSumOfSentiments);
        }

        private bool IsNeutral(int oldWeight, int actualWeight)
        {
            // We multiple them because if we have sentiments from oposite sides the result is neutral
            return oldWeight * actualWeight < 0;
        }

        private PhraseState GetPhraseStateFromNumber(int actualSumOfSentiments)
        {
            PhraseState finalPhraseState;

            if (actualSumOfSentiments > 3)
            {
                finalPhraseState = PhraseState.HIGH_POSITIVE;
            }
            else if (actualSumOfSentiments < -3)
            {
                finalPhraseState = PhraseState.HIGH_NEGATIVE;
            }
            else
            {
                finalPhraseState = (PhraseState) actualSumOfSentiments;
            }

            return finalPhraseState;
        }       

        public string GetStringFromPhraseState()
        {
            string name = "";

            switch (PhraseState)
            {
                case PhraseState.HIGH_POSITIVE:
                    name = "Altamente Positivo";
                    break;
                case PhraseState.MEDIUM_POSITIVE:
                    name = "Medianamente Positivo";
                    break;
                case PhraseState.LOW_POSITIVE:
                    name = "Poco Positivo";
                    break;
                case PhraseState.NEUTRAL:
                    name = "Neutral";
                    break;
                case PhraseState.LOW_NEGATIVE:
                    name = "Poco Negativo";
                    break;
                case PhraseState.MEDIUM_NEGATIVE:
                    name = "Medianamente Negativo";
                    break;
                case PhraseState.HIGH_NEGATIVE:
                    name = "Altamente Positivo";
                    break;
            };

            return name;
        }
    }
}
