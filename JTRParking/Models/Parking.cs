using JTRParking.Classes;
using System;
using System.Collections.Generic;
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
        public string VehicleType{ get; set; }
        public string DriverName { get; set; }
        public string? DriverMobile { get; set; }
        public string Barcode { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public decimal Amount { get; set; }
        public ParkingStatus Status { get; set; }
        public ulong CreatedBy { get; set; }
        public ulong? ModifiedBy { get; set; }
        public DateTime? CreatedAt { get; set; }


 
}
}

