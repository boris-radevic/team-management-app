namespace TeamManagementApp.Models
{
    public class PositionAdditionalData : AdditionalData
    {
        public int Status { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
