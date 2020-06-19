using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class PhraseTypeConfiguration : EntityTypeConfiguration<Phrase>
    {
        public PhraseTypeConfiguration()
        {
            HasKey(x => x.Id);

            HasOptional(p => p.Entity)
                .WithMany(e => e.Phrases);
        }

    }
}

