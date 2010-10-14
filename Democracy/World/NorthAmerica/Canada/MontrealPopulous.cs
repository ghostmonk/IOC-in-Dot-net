using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class MontrealPopulous : IPopulous
    {
        public string Name { get; private set; }

        public bool IsLeftLeaning { get; set; }

        public bool IsRightLeaning { get; set; }

        public void AddImportantIssue( Issue issue, float importance )
        {
            
        }

        public float RateStanceOnIssue( Issue issue, float polarity, float modifier )
        {
            return new Random().Next();
        }
    }
}
