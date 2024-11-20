using TeamManagementApp.Models;

namespace TeamManagementApp.Services.Contracts
{
    public interface IHierarchyService
    {
        public List<GridNode> ConvertToGridNodes(Data data);
    }
}
