using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class EntityTimeLapseAlarmTypeConfiguration : EntityTypeConfiguration<EntityTimeLapseAlarm>
    {
        public EntityTimeLapseAlarmTypeConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
