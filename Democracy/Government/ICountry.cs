using System.Collections.Generic;

namespace Democracy.Government
{
    public interface ICountry : IEntity
    {
        IGovernment Government { set; get; }

        IPopulous Populous { set; get; }

        List<IRiding> Ridings { get; }

        ICountry AddRiding( IRiding riding );
    }
}
