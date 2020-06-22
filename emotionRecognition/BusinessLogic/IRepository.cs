using BusinessLogic.Entities;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IRepository
    {
        bool AddEntity(Entity entity);

        IEnumerable<Entity> GetEntities();

        Entity GetEntityFromName(string entityName);

        bool AddSentiment(Sentiment sentiment);

        IEnumerable<Sentiment> GetSentiments();

        IEnumerable<Sentiment> GetPositiveSentiments();

        IEnumerable<Sentiment> GetNegativeSentiments();

        bool RemoveUnusedSentiment(Sentiment sentiment);

        void AddPhrase(Phrase phrase);

        IEnumerable<Phrase> GetPhrases();

        void AddEntityAlarm(EntityTimeLapseAlarm alarm);

        IEnumerable<EntityTimeLapseAlarm> GetEntityAlarms();

        void AnalyzeEntityAlarms();

        void AnalyzePhrases();

        bool AddAuthor(Author author);

        IEnumerable<Author> GetAuthors();

        void AnalyzeAuthors();

        Author GetAuthorFromUsername(string username);

        void AddAuthorAlarm(AuthorTimeLapseAlarm alarm);

        IEnumerable<AuthorTimeLapseAlarm> GetAuthorAlarms();

        void AnalyzeAuthorAlarms();

    }
}
