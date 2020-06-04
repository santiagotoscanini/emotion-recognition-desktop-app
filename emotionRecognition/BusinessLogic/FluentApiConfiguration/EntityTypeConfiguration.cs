using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FluentApiConfiguration
{
    public class EntityTypeConfiguration : EntityTypeConfiguration<Entity>
    {
        public EntityTypeConfiguration()
        {
            this.HasKey<string>(x => x.Name);
        }
    }
}
