using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    public class SystemData
    {
        private readonly HashSet<Entity> entityList;
        private readonly HashSet<Sentiment> sentimentList;

        public SystemData()
        {
            entityList = new HashSet<Entity>();
            sentimentList = new HashSet<Sentiment>();
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
            return entityList.Contains(entity);
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
    }
}
