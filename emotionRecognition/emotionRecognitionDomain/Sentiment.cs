using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    public class Sentiment
    {
        public string Name { get; }

        public int State { get; }

        public Sentiment(string Name, int State)
        {
            this.Name = Name;
            this.State = State;
        }

        public override bool Equals(object obj)
        {
            return obj is Sentiment sentiment &&
                   Name == sentiment.Name;
        }
    }
}
