using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{

    public class EntityPersistence
    {
        private List<Entity> entities;

        public EntityPersistence()
        {
            entities = new List<Entity>();

        }

        public void Add(Entity aEntity)
        {
            entities.Add(aEntity);
        }

        public void Delete(Entity aEntity)
        {
            entities.Remove(aEntity);
        }

        public List<Entity> Get()
        {
            return entities;
        }
    }
}
