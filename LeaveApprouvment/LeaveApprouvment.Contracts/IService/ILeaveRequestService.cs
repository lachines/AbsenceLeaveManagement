using LeaveApprouvment.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Contracts.IService
{
    public interface ILeaveRequestService
    {
        LeaveRquest AddLeaveRequest(LeaveRquest leaveRquest);
        LeaveRquest UpdateLeaveRequest(LeaveRquest leaveRquest);
        void DeleteLeaveRequest(int leaveRquestId);

        List<LeaveRquest> GetLeaveRequestByManager(int managerId);

        Task<LeaveRquest> AddLeaveRequestAsync(LeaveRquest leaveRquest);
        Task<LeaveRquest> UpdateLeaveRequestAsync(LeaveRquest leaveRquest);
        Task DeleteLeaveRequestAsync(int leaveRquestId);

        Task<List<LeaveRquest>> GetLeaveRequestByManagerAsync(int managerId);
    }
}
