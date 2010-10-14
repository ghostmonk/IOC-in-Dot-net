using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;

namespace Democracy.World.NorthAmerica.Canada
{
    public class MontrealPopulous : Populous
    {
        public MontrealPopulous() : base( "City of Montreal" )
        {
            BipartisanRating = -0.4f;
        }
    }
}
