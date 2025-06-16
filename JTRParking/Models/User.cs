using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTRParking.Models
{
    public class User
    {
        public enum UserRole
        {
            ADMIN,
            EMPLOYEE_IN,
            EMPLOYEE_OUT
        }

        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }


        public virtual ICollection<Shift> Shifts { get; set; }

        [InverseProperty("Creator")]
        public virtual ICollection<Parking> CreatedParkings { get; set; }

        [InverseProperty("Modifier")]
        public virtual ICollection<Parking> ModifiedParkings { get; set; }
    }
}
