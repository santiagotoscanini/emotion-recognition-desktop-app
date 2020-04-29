namespace BussinessLogic
{
    public class Entity
    {
        public string Name { get; }
        public Entity()
        {
            this.Name = "";
        }
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
