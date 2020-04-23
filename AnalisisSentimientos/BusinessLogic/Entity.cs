using System;

namespace BusinessLogic
{
    public class Entity
    {
        public String Name { get; set; }

        public Entity()
        {

        }
        public Entity(String name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            // If the passed object is null
            if (obj == null)
            {
                return false;
            }
            // If the passed object is not an entity
            if (!(obj is Entity))
            {
                return false;
            }
            return (Name == ((Entity)obj).Name));
        }

        public override String ToString()
        {
            return Name;
        }
    }
}