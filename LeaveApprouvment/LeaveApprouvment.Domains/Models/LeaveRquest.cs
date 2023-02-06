using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    [Table("LeaveRquest")]
    public class LeaveRquest
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string TypeOfRequest { get; set; }
        public string Comment { get; set; }
        public string PieceJustficatif { get; set; }
        public Status Status{ get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int? ManagerId { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
