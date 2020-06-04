using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class PhraseTypeConfiguration : EntityTypeConfiguration<Phrase>
    {
        public PhraseTypeConfiguration()
        {
            this.HasKey<int>(x => x.Id);
            this.HasOptional<Entity>(p => p.Entity)
                .WithMany(e => e.Phrases)
                .HasForeignKey<string>(p => p.EntityKey);
        }

    }
}

