using System.Collections.Generic;
using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPoliticalParty : IEntity
    {
        float ApprovalRating { get; }

        PartyType Type { get; }

        IPolitician Leader { get; set; }

        List<IPolitician> Politicians { get; }

        string GetPosition( Issue issue );

        void AdjustApprovalRating( float adjustment );
    }
}
