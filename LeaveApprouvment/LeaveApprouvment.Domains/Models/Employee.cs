using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public  string Email { get; set; }
        public string Team { get; set; }

        public string Poste { get; set; }
        public int? ManagerId { get; set; }
        public virtual Manager Manager { get; set; }

    }
}
