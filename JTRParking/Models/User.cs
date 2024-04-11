using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

    }
}
