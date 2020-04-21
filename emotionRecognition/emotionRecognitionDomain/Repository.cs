using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static BussinessLogic.Module;

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
            return new HashSet<Entity>(this.entityList);
        }
        public HashSet<Sentiment> GetSentiments()
        {
            return new HashSet<Sentiment>(this.sentimentList);
        }
        public HashSet<Phrase> GetPhrases()
        {
            return new HashSet<Phrase>(this.phraseList);
        }

        public bool addEntity(Entity entity)
        {
            bool sucess = false;
            if (!this.hasEntity(entity))
            {
                sucess = true;
                this.entityList.Add(entity);
            }
            return sucess;
        }

        public bool hasEntity(Entity entity)
        {
            return this.entityList.Contains(entity);
        }

        public bool removeEntity(Entity entity)
        {
            bool sucess = false;
            if (this.hasEntity(entity))
            {
                sucess = true;
                this.entityList.Remove(entity);
            }
            return sucess;
        }

        public bool hasSentiment(Sentiment sentiment)
        {
            return this.sentimentList.Contains(sentiment);
        }

        public bool addSentiment(Sentiment sentiment)
        {
            bool sucess = false;
            if (!this.hasSentiment(sentiment))
            {
                sucess = true;
                this.sentimentList.Add(sentiment);
            }
            return sucess;
        }

        public bool removeSentiment(Sentiment sentiment)
        {
            bool sucess = false;
            if (this.hasSentiment(sentiment))
            {
                sucess = true;
                this.sentimentList.Remove(sentiment);
            }
            return sucess;
        }

        public bool hasPhrase(Phrase phrase)
        {
            return this.phraseList.Contains(phrase);
        }

        public bool addPhrase(Phrase phrase)
        {
            bool sucess = false;
            if (!this.hasPhrase(phrase))
            {
                sucess = true;
                this.phraseList.Add(phrase);
            }
            return sucess;
        }

        public bool removePhrase(Phrase phrase)
        {
            bool sucess = false;
            if (this.hasPhrase(phrase))
            {
                sucess = true;
                this.phraseList.Remove(phrase);
            }
            return sucess;
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
