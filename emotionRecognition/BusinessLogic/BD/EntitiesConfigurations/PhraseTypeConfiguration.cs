using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class PhraseTypeConfiguration : EntityTypeConfiguration<Phrase>
    {
        public PhraseTypeConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
