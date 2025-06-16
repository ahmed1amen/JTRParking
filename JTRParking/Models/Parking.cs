using JTRParking.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTRParking.Models
{
    public class Parking
    {
        public enum ParkingStatus
        {
            PENDING,
            COMPLETED
        }


        public ulong Id { get; set; }
        public string VehicleType { get; set; }
        public string DriverName { get; set; }
        public string? DriverMobile { get; set; }
        public string Barcode { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public ParkingStatus Status { get; set; }

        public ulong? ShiftId { get; set; }
        public virtual Shift? Shift { get; set; }

        public ulong CreatedBy { get; set; }
        public ulong? ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("CreatedBy")]
        public virtual User? Creator { get; set; }

        [ForeignKey("ModifiedBy")]
        public virtual User? Modifier { get; set; }
    }
}

