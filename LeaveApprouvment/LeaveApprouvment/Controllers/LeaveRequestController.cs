using LeaveApprouvment.Contracts.IService;
using LeaveApprouvment.Domains.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeaveApprouvment.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestService _leaveRequestService;
        public LeaveRequestController(ILeaveRequestService leaveRequestService)
        {
            _leaveRequestService = leaveRequestService; 

        }



        [HttpPost]
        public async Task<LeaveRquest> AddLeaveRequestAsync(LeaveRquest leaveRquest)
        {
            return await _leaveRequestService.AddLeaveRequestAsync(leaveRquest);
        }
        [HttpPut]
        public async Task<LeaveRquest> UpdateLeaveRequestAsync(LeaveRquest leaveRquest)
        {
            return await _leaveRequestService.UpdateLeaveRequestAsync(leaveRquest);
        }
        [HttpDelete("{leaveRquestId:int}")]
        public async Task DeleteLeaveRequestAsync(int leaveRquestId)
        {
             await _leaveRequestService.DeleteLeaveRequestAsync(leaveRquestId);
        }
        [HttpGet("{managerId:int}")]
        public async Task<List<LeaveRquest>> GetLeaveRequestByManagerAsync(int managerId)
        {
            return await _leaveRequestService.GetLeaveRequestByManagerAsync(managerId);
        }

    }
}
