using System;

namespace BussinessLogic
{
    public class Entity
    {
        public string Name { get; }

        public Entity(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Text cannot be null or empty", "Text");
            }
            this.Name = Name;
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
    }
}
