namespace TeamManagementApp.Models
{
    public class GridNode
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsExpanded { get; set; } = false;
        public AdditionalData? AdditionalData{get; set;}
        public List<GridNode> Children { get; set; } = new List<GridNode>();
    }
}
