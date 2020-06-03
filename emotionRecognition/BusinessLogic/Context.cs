using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Context : DbContext
    {
        public DbSet<Phrase> Phrases { get; set; }
        private DbSet<Entity> Entities { get; set; }
        private DbSet<Sentiment> Sentiments { get; set; }
        private DbSet<TimeLapseAlarm> Alarms { get; set; }
    }
}
