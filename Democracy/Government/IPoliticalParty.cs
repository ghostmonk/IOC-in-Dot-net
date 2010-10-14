using System.Collections.Generic;
using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPoliticalParty : IEntity
    {
        double ApprovalRating { get; }

        PartyType Type { get; }

        IPolitician Leader { get; set; }

        List<IPolitician> Politicians { get; }

        string GetPosition( Issue issue );

        void AdjustApprovalRating( double adjustment );
    }
}
