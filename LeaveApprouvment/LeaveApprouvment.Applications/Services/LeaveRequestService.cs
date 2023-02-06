using LeaveApprouvment.Contracts.IService;
using LeaveApprouvment.Domains.IRepositories;
using LeaveApprouvment.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Applications.Services
{
    public class LeaveRequestService : ILeaveRequestService
    {
        #region Fields
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        #endregion

        #region Constructors
        public LeaveRequestService(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository= leaveRequestRepository;
        }
        #endregion
        public LeaveRquest AddLeaveRequest(LeaveRquest leaveRquest)
        {
            return _leaveRequestRepository.AddLeaveRequest(leaveRquest);
        }

        public Task<LeaveRquest> AddLeaveRequestAsync(LeaveRquest leaveRquest)
        {
            return Task.Run(()=> AddLeaveRequest(leaveRquest));
        }

        public void DeleteLeaveRequest(int leaveRquestId)
        {
            _leaveRequestRepository.DeleteLeaveRequest(leaveRquestId);
        }

        public Task DeleteLeaveRequestAsync(int leaveRquestId)
        {
            return Task.Run(() => DeleteLeaveRequest(leaveRquestId));
        }

        public List<LeaveRquest> GetLeaveRequestByManager(int managerId)
        {
            return _leaveRequestRepository.GetLeaveRequestByManager(managerId);
        }

        public Task<List<LeaveRquest>> GetLeaveRequestByManagerAsync(int managerId)
        {
            return Task.Run(() => GetLeaveRequestByManager(managerId));
        }

        public LeaveRquest UpdateLeaveRequest(LeaveRquest leaveRquest)
        {
            return _leaveRequestRepository.UpdateLeaveRequest(leaveRquest);
        }

        public Task<LeaveRquest> UpdateLeaveRequestAsync(LeaveRquest leaveRquest)
        {
            return Task.Run(()=> UpdateLeaveRequest(leaveRquest));
        }
    }
}
