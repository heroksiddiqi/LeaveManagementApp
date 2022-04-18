using LeaveManagementApp.Contracts;
using LeaveManagementApp.Data;

namespace LeaveManagementApp.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
