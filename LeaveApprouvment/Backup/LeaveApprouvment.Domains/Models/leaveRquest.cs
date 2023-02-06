using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.Models
{
    public class leaveRquest
    {
        public int leaveRquestId { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public string typeOfRequest { get; set; }
        public string comment { get; set; }
        public string pieceJustficatif { get; set; }

    }
}
