using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Canada : ICountry
    {
        public Canada()
        {
            Name = "Canada";
            Ridings = new List<IRiding>();
        }

        public string Name { get; private set; }

        public IGovernment Government { get; set; }

        public IPopulous Populous { get; set; }

        public List<IRiding> Ridings { get; private set; }

        public ICountry AddRiding( IRiding riding )
        {
            Ridings.Add( riding);
            return this;
        }
    }
}
