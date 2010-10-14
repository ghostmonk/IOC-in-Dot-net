using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    class Drone : IBureaucrat
    {
        public Drone( string name, IDepartment department, ManagementStyle managementStyle )
        {
            Name = name;
            Department = department;
            ManagementStyle = managementStyle;
        }

        public string Name { get; private set; }

        public IDepartment Department { get; set; }

        public ManagementStyle ManagementStyle { get; set; }
    }
}
