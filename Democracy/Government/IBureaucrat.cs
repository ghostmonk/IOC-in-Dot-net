using Democracy.Definitions;

namespace Democracy.Government
{
    public interface IBureaucrat : IEntity
    {
        IDepartment Department { get; set; }

        ManagementStyle ManagementStyle { get; set; }
    }
}
