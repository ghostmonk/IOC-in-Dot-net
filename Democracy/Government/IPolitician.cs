using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPolitician : IEntity
    {
        IRiding Riding { get; set; }

        IPoliticalParty Party { get; set; }

        IDepartment Ministry { get; set; }

        bool HasPortfolio { get; }

        float ApprovalRating { get; }

        float AdjustApprovalRating( float adjustment );

        string GetSoundBite( Issue issue );
    }
}
