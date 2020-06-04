using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.FluentApiConfiguration
{
    public class SentimentTypeConfiguration : EntityTypeConfiguration<Sentiment>
    {
        public SentimentTypeConfiguration()
        {
            this.HasKey<string>(x => x.Text);          
        }
    }
}
