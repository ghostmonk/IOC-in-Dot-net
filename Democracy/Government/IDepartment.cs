using System.Collections.Generic;

namespace Democracy.Government
{
    public interface IDepartment : IEntity
    {
        IPolitician HeadMinister { get; set; }

        List<IBureaucrat> Bureaucrats { get;  }

        IDepartment AddBureaucrat( IBureaucrat bureaucrat );

        double Budget { get; set; }
    }
}
