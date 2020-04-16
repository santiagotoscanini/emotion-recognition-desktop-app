using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    public class SystemData
    {
        private List<Entity> entityList;
        public SystemData()
        {
            entityList = new List<Entity>();
        }

        public bool addEntity(Entity entity)
        {
            bool sucess = false;
            if (!hasEntity(entity))
            {
                sucess = true;
                this.entityList.Add(entity);
            }
            return sucess;
        }

        public bool hasEntity(Entity entity)
        {
            return entityList.Contains(entity);
        }

        public bool removeEntity(Entity entity)
        {
            bool sucess = false;
            if (hasEntity(entity))
            {
                sucess = true;
                this.entityList.Remove(entity);
            }
            return sucess;
        }
    }
}
