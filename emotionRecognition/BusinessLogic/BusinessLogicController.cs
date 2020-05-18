using System.Collections.Generic;

namespace BusinessLogic
{
    public class BusinessLogicController
    {
        public Repository Repository { get; private set; }

        public BusinessLogicController(Repository repository)
        {
            this.Repository= repository;
        }

        public bool AddEntity(string name)
        {
            Entity entityToAdd = new Entity(name);
            return Repository.AddEntity(entityToAdd);
        }

        public HashSet<Entity> GetEntities()
        {
            return Repository.GetEntities();
        }
    }
}
