using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    public class Entity
    {
        public string Name { get; set; }

        public Entity(string Name)
        {
            this.Name = Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Entity entity &&
                   Name == entity.Name;
        }
    }
}
