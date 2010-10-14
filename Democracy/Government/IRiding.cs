using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IRiding : IEntity
    {
        int Population { get; }

        IPopulous Populous { get; }

        Issue MostImportantIssue { get; set; }

        IPolitician ElectedRepresentative { get; set; }
    }
}
