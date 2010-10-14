using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Definitions;

namespace Democracy.Government.GeneralImp
{
    public class PoliticalParty : Entity, IPoliticalParty
    {
        private double adjustment;
        private IPolitician leader;

        public PoliticalParty( string name ) : base( name )
        {
            adjustment = 0;
        }

        public virtual PartyType Type { get; set; }

        public virtual IPolitician Leader
        {
            get { return leader; }
            set 
            { 
                leader = value;
                if( !Politicians.Contains( leader ) ) Politicians.Add( leader );
            }
        }

        public virtual List<IPolitician> Politicians { get; set; }

        public double ApprovalRating
        {
            get
            {
                return CalculateApprovalRating() + adjustment;
            }
        }

        public virtual string GetPosition( Issue issue )
        {
            return "Always not interested";
        }

        public virtual void AdjustApprovalRating( double adjustment )
        {
            this.adjustment += adjustment;
        }

        private double CalculateApprovalRating()
        {
            double rating = 0;

            foreach( IPolitician politician in Politicians )
            {
                rating += politician.ApprovalRating;
            }

            return Politicians.Count > 0 ? rating / Politicians.Count : 0;
        }
    }
}
