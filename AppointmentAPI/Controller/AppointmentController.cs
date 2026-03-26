using AppointmentAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Book(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return Ok(appointment);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Appointments.ToList());
        }
    }
}
