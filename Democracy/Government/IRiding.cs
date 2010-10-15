using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IRiding : IEntity
    {
        int Population { get; set; }

        IPopulous Populous { get; }

        Issue MostImportantIssue { get; set; }

        IPolitician ElectedRepresentative { get; set; }
    }
}
