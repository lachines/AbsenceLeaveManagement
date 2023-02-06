using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    [Table("Manager")]
    public class Manager
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public string Email { get; set; }
        public virtual IList<Employee> Employees { get; set; }  
        public virtual IList<LeaveRquest>  LeaveRquests { get; set; }
    }
}
