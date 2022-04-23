using HRLeaveManagement.Application.Contracts;
using HRLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HRLeaveManagement.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveRequestRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id)
        {
            var leaveRequests = await _dbContext.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q=>q.Id == id);
            return leaveRequests;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync()
        {
            var leaveRequest = await _dbContext.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            return leaveRequest;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approved)
        {
            leaveRequest.Approved = approved;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
