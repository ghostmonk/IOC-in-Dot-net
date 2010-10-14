using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class Conservatives : IPoliticalParty
    {
        private float adjustment;

        public Conservatives()
        {
            Type = PartyType.Conservative;
            Name = "Conservatives of Canada";
            Politicians = new List<IPolitician>();
        }

        public string Name { get; private set; }

        public float ApprovalRating
        {
            get
            {
                return CalculateApprovalRating() + adjustment;
            }
        }

        public PartyType Type { get; private set; }

        public IPolitician Leader { get; set; }

        public List<IPolitician> Politicians { get; private set; }

        public string GetPosition( Issue issue )
        {
            return "";
        }

        public void AdjustApprovalRating( float adjustment )
        {
            this.adjustment += adjustment;
        }

        private float CalculateApprovalRating()
        {
            float rating = 0;

            foreach( IPolitician politician in Politicians )
            {
                rating += politician.ApprovalRating;    
            }

            return Politicians.Count > 0 ? rating / Politicians.Count : 0;
        }
    }
}
