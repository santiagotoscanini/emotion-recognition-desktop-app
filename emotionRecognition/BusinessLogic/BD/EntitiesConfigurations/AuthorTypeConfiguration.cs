using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class AuthorTypeConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorTypeConfiguration()
        {
            HasKey(x => x.Username);
        }
    }
}
