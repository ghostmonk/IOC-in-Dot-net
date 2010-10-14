using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;

namespace Democracy.Government.GeneralImp
{
    public class Bureaucrat : Entity, IBureaucrat
    {
        public Bureaucrat( string name ) : base( name ) {}

        public virtual IDepartment Department { get; set; }

        public virtual ManagementStyle ManagementStyle { get; set; }
    }
}
