using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Democracy.Government.GeneralImp
{
    public class Government : Entity, IGovernment
    {
        private const float FAILED_APPROVAL = -5;

        public Government( string name ) : base( name )
        {
            PoliticalParties = new List<IPoliticalParty>();
            Departments = new List<IDepartment>();
        }

        public virtual IPoliticalParty PartyInPower { get; set; }

        public virtual List<IPoliticalParty> PoliticalParties { get; private set; }

        public virtual List<IDepartment> Departments { get; private set; }

        public virtual void AddPoliticalParty( IPoliticalParty party )
        {
            PoliticalParties.Add( party );
        }

        public virtual void AddDepartment( IDepartment department )
        {
            Departments.Add( department );
        }

        public virtual void CallElection()
        {
            PartyInPower = null;
            double bestApprovalRating = 0;

            foreach( IPoliticalParty party in PoliticalParties )
            {
                if( party.ApprovalRating <= bestApprovalRating )
                    continue;
                PartyInPower = party;
                bestApprovalRating = party.ApprovalRating;
            }
        }

        public virtual void DissolveGovernment()
        {
            PartyInPower.AdjustApprovalRating( FAILED_APPROVAL );
            CallElection();
        }
    }
}
