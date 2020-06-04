using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FluentApiConfiguration
{
    public class TimeLapseAlarmTypeConfiguration : EntityTypeConfiguration<TimeLapseAlarm>
    {
        public TimeLapseAlarmTypeConfiguration()
        {
            this.HasKey<int>(x => x.Id);
        }
    }
}
