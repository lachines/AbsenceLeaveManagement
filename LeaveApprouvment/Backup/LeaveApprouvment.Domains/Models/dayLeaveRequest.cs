using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    public class dayLeaveRequest
    {
        public int dayLeaveRquestId { get; set; }
        public  string timeOfLeaving{ get; set; }
        public string reason { get; set; }
        public string comment { get; set; }
        public string pieceJustficatif { get; set; }

    }
}
