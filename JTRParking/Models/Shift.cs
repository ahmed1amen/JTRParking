using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTRParking.Models
{
    public enum ShiftStatus
    {
        CLOSED,
        OPEN

    }

    public class Shift
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public TimeSpan StartTime { get; set; }  // Only time
        public TimeSpan EndTime { get; set; }    // Only time
        public ShiftStatus Status { get; set; }
        public ulong UserId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public virtual User User { get; set; }

        public virtual ICollection<Parking> Parkings { get; set; } = null!;

    }
}
