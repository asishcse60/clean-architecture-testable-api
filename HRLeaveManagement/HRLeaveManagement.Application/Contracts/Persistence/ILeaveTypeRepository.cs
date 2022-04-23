using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository:IGenericRepository<LeaveType>
    {
        Task<LeaveType> GetLeaveTypeWithDetailsAsync(int id);
        Task<List<LeaveType>> GetLeaveTypesWithDetailsAsync();
    }
}
