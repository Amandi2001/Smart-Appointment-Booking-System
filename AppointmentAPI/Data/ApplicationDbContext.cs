using Microsoft.EntityFrameworkCore;
using AppointmentAPI.Models;
using System.Collections.Generic;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Service> Services { get; set; }
}