namespace AppointmentAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initializing with empty string
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User";
    }
}