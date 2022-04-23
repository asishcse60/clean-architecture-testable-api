using HRLeaveManagement.Application.Contracts;
using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LeaveType> GetLeaveTypeWithDetailsAsync(int id)
        {
            return await GetAsync(id);
        }

        public async Task<List<LeaveType>> GetLeaveTypesWithDetailsAsync()
        {
            return await GetAllAsync();
        }
    }
}
