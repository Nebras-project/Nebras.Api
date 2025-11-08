using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Data.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }
        // !temp
        public string Grad { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
