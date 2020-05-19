using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class BusinessLogicController
    {
        public Repository Repository { get; private set; }

        public BusinessLogicController(Repository repository)
        {
            this.Repository= repository;
        }

        public bool AddEntity(string name)
        {
            Entity entityToAdd = new Entity(name);
            return Repository.AddEntity(entityToAdd);
        }

        public HashSet<Entity> GetEntities()
        {
            return Repository.GetEntities();
        }

        public void AddPhrase(string phraseText, DateTime dateTime)
        {
            Phrase phraseToAdd = new Phrase(phraseText, Repository.GetSentiments(), Repository.GetEntities(), dateTime);

            Repository.AddPhrase(phraseToAdd);
        }

        public List<Phrase> GetPhrases()
        {
            return Repository.GetPhrases();
        }
        
        public bool AddPositiveSentiment(string text)
        {
            Sentiment positiveSentimentToAdd = new Sentiment(text, Enums.SentimentState.POSITIVE);
            return Repository.AddSentiment(positiveSentimentToAdd);
        }

        public HashSet<Sentiment> GetPositiveSentiments()
        {
            return Repository.GetPositiveSentiments();
        }

        public bool DeletePositiveSentiment(string text)
        {
            return Repository.RemoveUnusedSentiment(new Sentiment(text, Enums.SentimentState.POSITIVE));
        }

        public bool AddNegativeSentiment(string text)
        {
            Sentiment negativeSentimentToAdd = new Sentiment(text, Enums.SentimentState.NEGATIVE);
            return Repository.AddSentiment(negativeSentimentToAdd);
        }

        public void AnalizePhrases()
        {
            foreach(Phrase phrase in Repository.GetPhrases())
            {
                phrase.Analyze(Repository.GetSentiments(),Repository.GetEntities());
            }
        }

        public HashSet<Sentiment> GetNegativeSentiments()
        {
            return Repository.GetNegativeSentiments();
        }

        public bool DeleteNegativeSentiment(string text)
        {
            return Repository.RemoveUnusedSentiment(new Sentiment(text, Enums.SentimentState.NEGATIVE));
        }
    }
}
