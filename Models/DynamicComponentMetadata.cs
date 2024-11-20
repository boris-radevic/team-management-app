namespace TeamManagementApp.Models
{
    public class DynamicComponentMetadata
    {
        public required Type ComponentType { get; init; }
        public Dictionary<string, object> Parameters { get; } = [];
    }
}
