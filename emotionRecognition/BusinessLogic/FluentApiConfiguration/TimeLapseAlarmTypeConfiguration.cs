using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.FluentApiConfiguration
{
    public class TimeLapseAlarmTypeConfiguration : EntityTypeConfiguration<TimeLapseAlarm>
    {
        public TimeLapseAlarmTypeConfiguration()
        {
            HasKey(x => x.Id);

            HasRequired(a => a.Entity)
                .WithMany(e => e.Alarms);
        }
    }
}
