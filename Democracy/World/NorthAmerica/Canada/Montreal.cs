using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Montreal : Riding 
    {
        public Montreal( IPopulous populous ) : base( "City of Montreal", populous ) { }
    }
}
