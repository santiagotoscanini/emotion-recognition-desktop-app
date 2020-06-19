using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class Entity
    {
        public string Name { get; set; }
        public ICollection<Phrase> Phrases { get; set; }

        public Entity() { }

        public Entity(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Text cannot be null or empty", "Text");
            }
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Entity entity = obj as Entity;
            return Name.Equals(entity.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
