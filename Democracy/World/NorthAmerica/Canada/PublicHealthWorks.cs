using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class PublicHealthWorks : IDepartment 
    {
        public PublicHealthWorks()
        {
            Name = "Public Health Works";
            Bureaucrats = new List<IBureaucrat>();
        }

        public string Name { get; private set; }

        public IPolitician HeadMinister { get; set; }

        public double Budget { get; set; }

        public List<IBureaucrat> Bureaucrats { get; private set; }

        public IDepartment AddBureaucrat( IBureaucrat bureaucrat )
        {
            Bureaucrats.Add( bureaucrat );
            return this;
        }
    }
}
