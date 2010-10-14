using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Democracy.Government;

namespace Democracy.World.NorthAmerica.Canada
{
    public class CanadianGovernment : IGovernment
    {
        private const float FAILED_APPROVAL = -5;

        private ICountry country;

        public CanadianGovernment( ICountry country )
        {
            this.country = country;
            Name = "Government of Canada";
            PoliticalParties = new List<IPoliticalParty>();
            Departments = new List<IDepartment>();
        }

        public string Name { get; private set; }

        public IPoliticalParty PartyInPower { get; private set; }

        public List<IPoliticalParty> PoliticalParties { get; private set; }

        public List<IDepartment> Departments { get; private set; }

        public void AddPoliticalParty( IPoliticalParty party )
        {
            PoliticalParties.Add( party );
        }

        public void AddDepartment( IDepartment department )
        {
            Departments.Add( department );
        }

        public void CallElection()
        {
            float bestApprovalRating = 0;

            foreach( IPoliticalParty party in PoliticalParties )
            {
                if( party.ApprovalRating <= bestApprovalRating ) continue;
                PartyInPower = party;
                bestApprovalRating = party.ApprovalRating;
            }
        }

        public void DissolveGovernment()
        {
            PartyInPower.AdjustApprovalRating( FAILED_APPROVAL );
            CallElection();
        }
    }
}
