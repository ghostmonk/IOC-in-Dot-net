using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Montreal : IRiding 
    {
        public string Name { get; private set; }

        public int Population { get; set; }

        public IPopulous Populous { get; private set; }

        public Issue MostImportantIssue { get; set; }

        public IPolitician ElectedRepresentative { get; set; }
    }
}
