﻿using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class EntityTypeConfiguration : EntityTypeConfiguration<Entity>
    {
        public EntityTypeConfiguration()
        {
            HasKey(x => x.Name);

            //HasMany(x => x.Alarms)
            //    .WithOptional(a => a.Entity)
            //    .HasForeignKey(a => a.EntityKey);
        }
    }
}
