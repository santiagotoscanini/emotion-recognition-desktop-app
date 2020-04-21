using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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

        public Entity getEntityFromPhrase(Phrase phrase)
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
    }
}
