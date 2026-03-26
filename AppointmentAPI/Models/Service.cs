namespace AppointmentAPI.Models
{
    public class Service
    {
        public int Id { get; set; }

        // Initializing with string.Empty avoids the "Non-nullable property" warning
        public string ServiceName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}