using Microsoft.EntityFrameworkCore;
using MedicalRecords.Core.Entities;

namespace MedicalRecords.Infrastructure.Data
{
public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
}
}