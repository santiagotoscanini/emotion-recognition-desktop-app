using System;
using System.Collections.Generic;
using BussinessLogic.Enums;

namespace BussinessLogic 
{
    public class Phrase
    {
        public string Text { get; }
        public DateTime CreationDate { get; }
        public Entity Entity { get; private set; }
        public PhraseState PhraseState { get; private set; }

        public Phrase(string Text, HashSet<Sentiment> sentiments, HashSet<Entity> entities, DateTime CreationDate)
        {
            if (string.IsNullOrEmpty(Text))
            {
                throw new ArgumentException("Text cannot be null or empty", "Text");
            }
            if(sentiments == null)
            {
                throw new ArgumentNullException("Sentiments", "Sentiments cannot be null");
            }
            if (entities == null)
            {
                throw new ArgumentNullException("Entities", "Entities cannot be null");
            }

            this.Text = Text;
            this.CreationDate = CreationDate;
            Analyze(sentiments, entities);
        }

        public void Analyze(HashSet<Sentiment> sentiments, HashSet<Entity> entities)
        {
            Entity = GetEntity(entities);
            PhraseState = GetPhraseState(sentiments);
        }

        private Entity GetEntity(HashSet<Entity> entities)
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

        private PhraseState GetPhraseState(HashSet<Sentiment> sentiments)
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
                finalPhraseState = PhraseState.LOW_POSITIVE;
            }
            else
            {
                finalPhraseState = (PhraseState) actualSumOfSentiments;
            }

            return finalPhraseState;
        }
    }
}
