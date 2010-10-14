using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPopulous : IEntity
    {
        bool IsLeftLeaning { get; set; }

        bool IsRightLeaning { get; set; }

        void AddImportantIssue( Issue issue, float importance );

        float RateStanceOnIssue( Issue issue, float polarity, float modifier );
    }
}
