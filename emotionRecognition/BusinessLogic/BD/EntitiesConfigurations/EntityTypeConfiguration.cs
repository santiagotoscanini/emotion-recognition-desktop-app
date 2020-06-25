using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class EntityTypeConfiguration : EntityTypeConfiguration<Entity>
    {
        public EntityTypeConfiguration()
        {
            HasKey(x => x.Name);
        }
    }
}
