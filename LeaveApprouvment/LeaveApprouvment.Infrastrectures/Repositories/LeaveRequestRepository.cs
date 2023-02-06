using LeaveApprouvment.Domains.IRepositories;
using LeaveApprouvment.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApprouvment.Infrastrectures.Repositories
{
    public class LeaveRequestRepository:RepositoryBase<LeaveRquest>, ILeaveRequestRepository
    {
        #region Fields
        private readonly DBContext _context;
        #endregion

        #region Constructors
        
        public LeaveRequestRepository(DBContext context) :base(context)
        {
            _context= context;
        }


        #endregion

        #region ILeaveRequestRepository Members
        public LeaveRquest AddLeaveRequest(LeaveRquest leaveRquest)
        {
            Add(leaveRquest);
            return leaveRquest;
        }

        public void DeleteLeaveRequest(int leaveRquestId)
        {
            var leaveRequestToDelete = _context.LeaveRquests.Where(x => x.Id == leaveRquestId).FirstOrDefault();
            if (leaveRequestToDelete != null)
            {
                Delete(leaveRequestToDelete);
            }
        }

        public List<LeaveRquest> GetLeaveRequestByManager(int managerId)
        {
            var result = _context.LeaveRquests.Where(x => x.ManagerId == managerId).ToList();
            result.ForEach(x =>
            {
                x.Manager = null;
                x.Employee = null;
            });
            return result;
            // return _context.LeaveRquests.Where(x => x.ManagerId == managerId).ToList();
        }

        public LeaveRquest UpdateLeaveRequest(LeaveRquest leaveRquest)
        {
           // var leaveRequestToUpdate = _context.LeaveRquests.Where(x=>x.Id== leaveRquest.Id).FirstOrDefault();
            Update(leaveRquest);
            return leaveRquest;
        }
        #endregion
    }
}
