using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class SentimentTypeConfiguration : EntityTypeConfiguration<Sentiment>
    {
        public SentimentTypeConfiguration()
        {
            HasKey(x => x.Text);
        }
    }
}
