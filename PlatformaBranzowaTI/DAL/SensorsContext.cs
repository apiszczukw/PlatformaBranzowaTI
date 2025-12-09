

using Microsoft.EntityFrameworkCore;
using PlatformaBranzowaTI.Models;

namespace PlatformaBranzowaTI.DAL
{
    public class SensorsContext : DbContext
    {
        public DbSet<SensorReport> SensorReports { get; set; }

        public SensorsContext(DbContextOptions<SensorsContext> options) : base(options)
        {
        }
    }
}
