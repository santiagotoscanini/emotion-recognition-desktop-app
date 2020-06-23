using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class TimeLapseAlarmTypeConfiguration : EntityTypeConfiguration<TimeLapseAlarm>
    {
        public TimeLapseAlarmTypeConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
