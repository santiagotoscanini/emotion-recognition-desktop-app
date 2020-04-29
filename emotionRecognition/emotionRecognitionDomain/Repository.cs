using System.Collections.Generic;

namespace BussinessLogic
{
    public class Repository
    {
        private HashSet<Entity> entityList;
        private HashSet<Sentiment> sentimentList;
        private HashSet<Phrase> phraseList;

        public Repository()
        {
            entityList = new HashSet<Entity>();
            sentimentList = new HashSet<Sentiment>();
            phraseList = new HashSet<Phrase>();
        }

        public HashSet<Entity> GetEntities()
        {
            return new HashSet<Entity>(entityList);
        }
        public HashSet<Sentiment> GetSentiments()
        {
            return new HashSet<Sentiment>(sentimentList);
        }
        public HashSet<Phrase> GetPhrases()
        {
            return new HashSet<Phrase>(phraseList);
        }

        public bool addEntity(Entity entity)
        {
            return entityList.Add(entity);
        }

        public bool hasEntity(Entity entity)
        {
            return entityList.Contains(entity);
        }

        public bool removeEntity(Entity entity)
        {    
            return entityList.Remove(entity);
        }

        public bool hasSentiment(Sentiment sentiment)
        {
            return sentimentList.Contains(sentiment);
        }

        public bool addSentiment(Sentiment sentiment)
        {
            return sentimentList.Add(sentiment);
        }

        public bool removeSentiment(Sentiment sentiment)
        {
            return sentimentList.Remove(sentiment);
        }

        public bool hasPhrase(Phrase phrase)
        {
            return phraseList.Contains(phrase);
        }

        public bool addPhrase(Phrase phrase)
        {
            return phraseList.Add(phrase);
        }

        public bool removePhrase(Phrase phrase)
        {
            return phraseList.Remove(phrase);
        }

        private Entity getEntityFromPhrase(Phrase phrase)
        {
            Entity entityOfPhrase = new Entity();
            int lastEntityIndex = phrase.Text.Length;
            foreach(Entity entity in entityList)
            {
                int entityPositionInEntity = phrase.Text.IndexOf(entity.Name);

                if (entityPositionInEntity != -1 && lastEntityIndex > entityPositionInEntity)
                {
                    entityOfPhrase = entity;
                    lastEntityIndex = entityPositionInEntity;
                }
            }
            return entityOfPhrase;
        }

        public void doAnalysis(Phrase phrase)
        {
            Entity entityOfPhrase = getEntityFromPhrase(phrase);
            PhraseState stateOfPhrase = getStateFromPhrase(phrase);

            phrase.SetAnalisisResult(entityOfPhrase, stateOfPhrase);
        }

        private PhraseState getStateFromPhrase(Phrase phrase)
        {
            PhraseState stateOfPhrase = PhraseState.NEUTRAL;
            int value = 0;
            foreach (Sentiment sentiment in sentimentList)
            {
                if (phrase.Text.Contains(sentiment.Name))
                {
                    if(value == 0)
                    {
                        value += sentiment.State == SentimentState.POSITIVE ? 1 : -1;
                    }
                    else if(sentiment.State == SentimentState.POSITIVE && value > 0)
                    {
                        value++;
                        if (value > 2)
                        {
                            break;
                        }
                    }
                    else if (sentiment.State == SentimentState.NEGATIVE && value < 0)
                    {
                        value--;
                        if (value < -2)
                        {
                            break;
                        }
                    }
                    else{
                        value = 0;
                        break;
                    }

                }
            }

            switch (value)
            {
                case 0:
                    stateOfPhrase = PhraseState.NEUTRAL;
                    break;
                case 1:
                    stateOfPhrase = PhraseState.LOW_POSITIVE;
                    break;
                case 2:
                    stateOfPhrase = PhraseState.MEDIUM_POSITIVE;
                    break;
                case 3:
                    stateOfPhrase = PhraseState.HIGH_POSITVE;
                    break;
                case -1:
                    stateOfPhrase = PhraseState.LOW_NEGATIVE;
                    break;
                case -2:
                    stateOfPhrase = PhraseState.MEDIUM_NEGATIVE;
                    break;
                case -3:
                    stateOfPhrase = PhraseState.HIGH_NEGATIVE;
                    break;
            }

            return stateOfPhrase;
        }
    }
}
