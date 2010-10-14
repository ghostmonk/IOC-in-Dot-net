using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;
using Democracy.Government.GeneralImp;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Conservatives : PoliticalParty
    {
        public Conservatives() : base( "Conservatives of Canada" )
        {
            Type = PartyType.Conservative;
        }

        override public string GetPosition( Issue issue )
        {
            return "We are shit heads";
        }
    }
}
