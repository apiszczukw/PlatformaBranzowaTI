

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var sensorReports = new List<SensorReport>
{
    new SensorReport { Id = 1,  Timestamp = DateTime.Now.AddMinutes(-290), Temperature = 21.5, Humidity = 45.2, Notes = "Normalna praca" },
    new SensorReport { Id = 2,  Timestamp = DateTime.Now.AddMinutes(-280), Temperature = 21.7, Humidity = 44.8, Notes = "Stabilne warunki" },
    new SensorReport { Id = 3,  Timestamp = DateTime.Now.AddMinutes(-270), Temperature = 22.0, Humidity = 44.1, Notes = null },
    new SensorReport { Id = 4,  Timestamp = DateTime.Now.AddMinutes(-260), Temperature = 22.3, Humidity = 43.9, Notes = "Lekki wzrost temperatury" },
    new SensorReport { Id = 5,  Timestamp = DateTime.Now.AddMinutes(-250), Temperature = 22.1, Humidity = 43.5, Notes = null },
    new SensorReport { Id = 6,  Timestamp = DateTime.Now.AddMinutes(-240), Temperature = 21.9, Humidity = 43.0, Notes = null },
    new SensorReport { Id = 7,  Timestamp = DateTime.Now.AddMinutes(-230), Temperature = 21.6, Humidity = 42.8, Notes = "Spadek wilgotności" },
    new SensorReport { Id = 8,  Timestamp = DateTime.Now.AddMinutes(-220), Temperature = 21.4, Humidity = 42.5, Notes = null },
    new SensorReport { Id = 9,  Timestamp = DateTime.Now.AddMinutes(-210), Temperature = 21.2, Humidity = 42.0, Notes = null },
    new SensorReport { Id = 10, Timestamp = DateTime.Now.AddMinutes(-200), Temperature = 21.0, Humidity = 41.8, Notes = "Stabilizacja" },

    new SensorReport { Id = 11, Timestamp = DateTime.Now.AddMinutes(-190), Temperature = 20.9, Humidity = 41.5, Notes = null },
    new SensorReport { Id = 12, Timestamp = DateTime.Now.AddMinutes(-180), Temperature = 20.8, Humidity = 41.2, Notes = null },
    new SensorReport { Id = 13, Timestamp = DateTime.Now.AddMinutes(-170), Temperature = 20.7, Humidity = 41.0, Notes = "Warunki optymalne" },
    new SensorReport { Id = 14, Timestamp = DateTime.Now.AddMinutes(-160), Temperature = 20.9, Humidity = 40.8, Notes = null },
    new SensorReport { Id = 15, Timestamp = DateTime.Now.AddMinutes(-150), Temperature = 21.1, Humidity = 40.5, Notes = null },
    new SensorReport { Id = 16, Timestamp = DateTime.Now.AddMinutes(-140), Temperature = 21.4, Humidity = 40.2, Notes = "Wzrost temperatury" },
    new SensorReport { Id = 17, Timestamp = DateTime.Now.AddMinutes(-130), Temperature = 21.8, Humidity = 40.0, Notes = null },
    new SensorReport { Id = 18, Timestamp = DateTime.Now.AddMinutes(-120), Temperature = 22.2, Humidity = 39.8, Notes = null },
    new SensorReport { Id = 19, Timestamp = DateTime.Now.AddMinutes(-110), Temperature = 22.5, Humidity = 39.5, Notes = "Cieplej niż zwykle" },
    new SensorReport { Id = 20, Timestamp = DateTime.Now.AddMinutes(-100), Temperature = 22.8, Humidity = 39.2, Notes = null },

    new SensorReport { Id = 21, Timestamp = DateTime.Now.AddMinutes(-90),  Temperature = 23.0, Humidity = 39.0, Notes = null },
    new SensorReport { Id = 22, Timestamp = DateTime.Now.AddMinutes(-80),  Temperature = 23.2, Humidity = 38.7, Notes = "Niska wilgotność" },
    new SensorReport { Id = 23, Timestamp = DateTime.Now.AddMinutes(-70),  Temperature = 23.4, Humidity = 38.5, Notes = null },
    new SensorReport { Id = 24, Timestamp = DateTime.Now.AddMinutes(-60),  Temperature = 23.6, Humidity = 38.3, Notes = null },
    new SensorReport { Id = 25, Timestamp = DateTime.Now.AddMinutes(-50),  Temperature = 23.8, Humidity = 38.0, Notes = "Zbliża się próg ostrzegawczy" },
    new SensorReport { Id = 26, Timestamp = DateTime.Now.AddMinutes(-40),  Temperature = 24.0, Humidity = 37.8, Notes = null },
    new SensorReport { Id = 27, Timestamp = DateTime.Now.AddMinutes(-30),  Temperature = 24.2, Humidity = 37.5, Notes = null },
    new SensorReport { Id = 28, Timestamp = DateTime.Now.AddMinutes(-20),  Temperature = 24.4, Humidity = 37.2, Notes = "Wysoka temperatura" },
    new SensorReport { Id = 29, Timestamp = DateTime.Now.AddMinutes(-10),  Temperature = 24.6, Humidity = 37.0, Notes = null },
    new SensorReport { Id = 30, Timestamp = DateTime.Now,              Temperature = 24.8, Humidity = 36.8, Notes = "Ostatni odczyt" }
};

            modelBuilder.Entity<SensorReport>().HasData(sensorReports);

        }
    }
}
