using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class CanadianGovernment : Government.GeneralImp.Government
    {
        private ICountry country;

        public CanadianGovernment( ICountry country ) : base( "Government of Canada"  )
        {
            this.country = country;
        }
    }
}
