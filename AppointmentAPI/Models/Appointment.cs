namespace AppointmentAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }

        // Setting a default value like "Pending" is a good practice for status fields
        public string Status { get; set; } = "Pending";
    }
}