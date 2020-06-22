using BusinessLogic.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BusinessLogic.BD.FluentApiConfiguration
{
    public class AuthorTimeLapseAlarmTypeConfiguration : EntityTypeConfiguration<AuthorTimeLapseAlarm>
    {
        public AuthorTimeLapseAlarmTypeConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
