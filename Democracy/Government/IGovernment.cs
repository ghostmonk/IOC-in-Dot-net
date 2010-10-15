using System.Collections.Generic;

namespace Democracy.Government
{
    public interface IGovernment : IEntity
    {
        IPoliticalParty PartyInPower { get; }

        List<IPoliticalParty> PoliticalParties { get; }

        List<IDepartment> Departments { get; }

        IGovernment AddPoliticalParty( IPoliticalParty party );

        IGovernment AddDepartment( IDepartment department );

        void CallElection();

        void DissolveGovernment();
    }
}
