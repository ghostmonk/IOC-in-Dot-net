using System.Collections.Generic;

namespace Democracy.Government
{
    public interface IGovernment : IEntity
    {
        IPoliticalParty PartyInPower { get; }

        List<IPoliticalParty> PoliticalParties { get; }

        List<IDepartment> Departments { get; }

        void AddPoliticalParty( IPoliticalParty party );

        void AddDepartment( IDepartment department );

        void CallElection();

        void DissolveGovernment();
    }
}
