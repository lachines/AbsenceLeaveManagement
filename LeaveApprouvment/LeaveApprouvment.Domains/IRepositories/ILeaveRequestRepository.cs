using LeaveApprouvment.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Domains.IRepositories
{
    public interface ILeaveRequestRepository:IRepositoryBase<LeaveRquest>
    {
        LeaveRquest AddLeaveRequest(LeaveRquest leaveRquest);
        LeaveRquest UpdateLeaveRequest(LeaveRquest leaveRquest);
        void DeleteLeaveRequest(int leaveRquestId);

        List<LeaveRquest> GetLeaveRequestByManager(int managerId);

    }
}
