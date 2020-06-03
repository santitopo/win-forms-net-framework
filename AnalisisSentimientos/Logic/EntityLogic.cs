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
        private EntityPersistence Entities { get; set; }

        public EntityLogic()
        {
            Entities = new EntityPersistence();
        }

        public void AddEntity(Entity anEntity)
        {
            if (RepeatedEntity(anEntity.Name))
            {
                throw new ApplicationException("no es posible agregar la misma entidad " +
                "o una subsecuencia de una entidad que ya se encuentra en la lista");
            }
            Entities.Get().Add(anEntity);
        }
        private bool RepeatedEntity(string name)
        {
            var nameLower = name.ToLower();
            //Three Cases: 
            //1. The name is excactly the same(lower/upper case also)
            //2. Name is a substring of f.Name
            //3. f.Name is a substring of Name
            foreach (Entity e in Entities.Get())
            {
                if (e.Name.ToLower().Contains(nameLower) || nameLower.Contains(e.Name.ToLower()))
                    return true;
            }
            return false;
        }

        public void DeleteEntity(Entity anEntity)
        {
            if (Entities.Get().Count == 0)
            {
                throw new InvalidOperationException("no es posible eliminar de una lista vacía");
            }
            Entities.Get().Remove(anEntity);
        }


        public Entity[] GetEntitites
        {
            get { return Entities.Get().ToArray(); }
        }
    }
}
