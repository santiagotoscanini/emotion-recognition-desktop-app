using BusinessLogic.Entities;
using BusinessLogic.BD.FluentApiConfiguration;
using System.Data.Entity;

namespace BusinessLogic.BD
{
    public class Context : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Sentiment> Sentiments { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<EntityTimeLapseAlarm> EntityAlarms { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorTimeLapseAlarm> AuthorAlarms { get; set; }

        public Context() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SentimentTypeConfiguration());
            modelBuilder.Configurations.Add(new PhraseTypeConfiguration());
            modelBuilder.Configurations.Add(new EntityTimeLapseAlarmTypeConfiguration());
            modelBuilder.Configurations.Add(new AuthorTypeConfiguration());
            modelBuilder.Configurations.Add(new AuthorTimeLapseAlarmTypeConfiguration());
        }
    }
}
