using System.ComponentModel.DataAnnotations;

namespace PlatformaBranzowaTI.Models
{
    public class SensorReport
    {
        // Klucz główny dla EF
        public int Id { get; set; }

        // II sposób
        //public int SensorReportId { get; set; }

        // III sposób
        // [Key]
        //public int SensorID { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public double Temperature { get; set; }

        [Required]
        public double Humidity { get; set; }

        public string? Notes { get; set; }
    }
}
