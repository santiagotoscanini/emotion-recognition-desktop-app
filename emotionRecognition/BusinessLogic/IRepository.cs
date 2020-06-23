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

        void AddAlarm(TimeLapseAlarm alarm);

        IEnumerable<TimeLapseAlarm> GetAlarms();

        void AnalyzeAlarms();

        void AnalyzePhrases();

        bool AddOrUpdateAuthor(Author author);

        void DeleteAuthorByUsername(string username);

        IEnumerable<Author> GetAuthors();

        void AnalyzeAuthors();

        Author GetAuthorFromUsername(string username);
    }
}
