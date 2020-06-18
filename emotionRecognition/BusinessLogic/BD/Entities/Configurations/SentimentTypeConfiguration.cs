using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class SentimentTypeConfiguration : EntityTypeConfiguration<Sentiment>
    {
        public SentimentTypeConfiguration()
        {
            HasKey(x => x.Text);          
        }
    }
}
