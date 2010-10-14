using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IPopulous : IEntity
    {
        double BipartisanRating { get; set; }

        void AddImportantIssue( Issue issue, double importance );

        double RateStanceOnIssue( Issue issue, double polarity, double modifier );
    }
}
