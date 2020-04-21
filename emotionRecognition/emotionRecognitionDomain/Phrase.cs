using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogic
{
    public class Phrase
    {
        public string Text { get; }
        public bool Analized { get; private set; }
        private Entity Entity { get; set; }
        private List<Sentiment> Sentiments { get; set; }
        private int Grade { get; set; }
        public Entity getEntityValue()
        {
            if (this.Analized)
            {
                return this.Entity;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }
        public List<Sentiment> getSentimentsValue()
        {
            if (this.Analized)
            {
                return this.Sentiments;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }
        public int getGradeValue()
        {
            if (this.Analized)
            {
                return this.Grade;
            }
            else
            {
                throw new InvalidOperationException("Phrase was not analized");
            }
        }
        public Phrase(string Text)
        {
            this.Text = Text;
            this.Entity = new Entity();
            this.Analized = false;
            this.Sentiments = new List<Sentiment>();
            this.Grade = 0;
        }
        public void SetAnalisisResult(Entity Entity, List<Sentiment> Sentiments)
        {
            if (this.Analized)
            {
                throw new InvalidOperationException("Phrase was analized already");
            }
            else
            {
                this.Analized = true;
                this.Entity = Entity;
                this.Sentiments = Sentiments;
                this.Grade = CalculateGrade();
            }
        }
        private int CalculateGrade()
        {
            return this.Sentiments.Sum(sentiment => sentiment.State);
        }
    }
}
