using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Democracy.Government.GeneralImp
{
    public class Entity : IEntity
    {
        public Entity( string name )
        {
            Name = name;
        }

        public virtual string Name { get; private set; }
    }
}
