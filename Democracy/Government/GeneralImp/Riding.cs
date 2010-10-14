using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;

namespace Democracy.Government.GeneralImp
{
    public class Riding : Entity, IRiding
    {
        public Riding( string name, IPopulous populous ) : base( name )
        {
            Populous = populous;
        }

        public int Population { get; set; }
        
        public IPopulous Populous { get; private set; }
        
        public Issue MostImportantIssue { get; set; }
        
        public IPolitician ElectedRepresentative { get; set; }
    }
}
