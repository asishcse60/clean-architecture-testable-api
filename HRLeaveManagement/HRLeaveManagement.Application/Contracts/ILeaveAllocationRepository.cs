using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetailsAsync(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetailsAsync();
    }
}
