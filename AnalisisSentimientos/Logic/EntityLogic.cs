using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EntityLogic
    {
        private Repository Repository{ get; }

        public EntityLogic(Repository repo)
        {
            Repository = repo;
        }

        public void AddEntity(Entity anEntity)
        {
            if (RepeatedEntity(anEntity.Name))
            {
                throw new ApplicationException("no es posible agregar la misma entidad " +
                "o una subsecuencia de una entidad que ya se encuentra en la lista");
            }
            Repository.AddEntity(anEntity);
        }
        private bool RepeatedEntity(string name)
        {
            var nameLower = name.ToLower();
            //Three Cases: 
            //1. The name is excactly the same(lower/upper case also)
            //2. Name is a substring of f.Name
            //3. f.Name is a substring of Name
            foreach (Entity e in Repository.GetEntities())
            {
                if (e.Name.ToLower().Contains(nameLower) || nameLower.Contains(e.Name.ToLower()) && !e.Deleted)
                    return true;
            }
            return false;
        }

        public void DeleteEntity(Entity anEntity)
        {
            if (Repository.GetEntities().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Repository.DeleteEntity(anEntity);
        }

        public Entity GetEntityByName(string aName)
        {
            if (Repository.GetEntities().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }

            return Repository.GetEntityByName(aName);
        }

        public Entity[] GetEntitites
        {
            get { return Repository.GetEntities().ToArray(); }
        }

        public void DeleteAllEntities()
        {
            Repository.DeleteAllEntities();
        }
    }
}
