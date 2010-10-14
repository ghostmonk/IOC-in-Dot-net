using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Drone : Bureaucrat
    {
        public Drone( string name, IDepartment department, ManagementStyle managementStyle ) : base( name )
        {
            Department = department;
            ManagementStyle = managementStyle;
        }
    }
}
