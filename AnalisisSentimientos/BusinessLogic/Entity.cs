using System;

namespace BusinessLogic
{
    public class Entity
    {
        public String Name { get; set; }
        public Entity(String name)
        {
            Name = name;
        }
    }
}