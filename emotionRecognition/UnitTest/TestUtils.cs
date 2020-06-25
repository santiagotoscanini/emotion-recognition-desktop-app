using BusinessLogic.BD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TestUtils
    {
        protected void CleanDB()
        {
            using (Context context = new Context())
            {
                context.Entities.RemoveRange(context.Entities);
                context.Sentiments.RemoveRange(context.Sentiments);
                context.EntityAlarms.RemoveRange(context.EntityAlarms);
                context.Phrases.RemoveRange(context.Phrases);
                context.Authors.RemoveRange(context.Authors);
                context.AuthorAlarms.RemoveRange(context.AuthorAlarms);

                context.SaveChanges();
            };
        }
    }
}
