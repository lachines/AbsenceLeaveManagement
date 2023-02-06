using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    public class manager
    {
        public int managerId { get; set; } 
        public string fullName { get; set; }
        public string team { get; set; }
        public string email { get; set; }
    }
}
