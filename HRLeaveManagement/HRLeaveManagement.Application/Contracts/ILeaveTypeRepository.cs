using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts
{
    public interface ILeaveTypeRepository:IGenericRepository<LeaveType>
    {
        Task<LeaveType> GetLeaveTypeWithDetailsAsync(int id);
        Task<List<LeaveType>> GetLeaveTypesWithDetailsAsync();
    }
}
