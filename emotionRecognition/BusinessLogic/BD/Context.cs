using BusinessLogic.FluentApiConfiguration;
using System.Data.Entity;

namespace BusinessLogic
{
    public class Context : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Sentiment> Sentiments { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<TimeLapseAlarm> Alarms { get; set; }

        public Context() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SentimentTypeConfiguration());
            modelBuilder.Configurations.Add(new PhraseTypeConfiguration());
            modelBuilder.Configurations.Add(new TimeLapseAlarmTypeConfiguration());
        }
    }
}
