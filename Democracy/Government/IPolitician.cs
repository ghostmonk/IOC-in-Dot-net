using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPolitician : IEntity
    {
        IRiding Riding { get; set; }

        IPoliticalParty Party { get; set; }

        IDepartment Ministry { get; set; }

        bool HasPortfolio { get; }

        double ApprovalRating { get; }

        double AdjustApprovalRating( double adjustment );

        string GetSoundBite( Issue issue );
    }
}
