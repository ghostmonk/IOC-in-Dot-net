using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class PublicHealthWorks : IDepartment 
    {
        public string Name { get; private set; }

        public IPolitician HeadMinister { get; set; }

        public float Budget { get; set; }

        public List<IBureaucrat> Bureaucrats { get; private set; }

        public IDepartment AddBureaucrat( IBureaucrat bureaucrat )
        {
            return this;
        }
    }
}
