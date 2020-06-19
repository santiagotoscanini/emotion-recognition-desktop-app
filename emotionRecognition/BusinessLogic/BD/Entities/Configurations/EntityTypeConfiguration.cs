using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class EntityTypeConfiguration : EntityTypeConfiguration<Entity>
    {
        public EntityTypeConfiguration()
        {
            this.HasKey<Entity>(x => x.Name);
        }
    }
}
