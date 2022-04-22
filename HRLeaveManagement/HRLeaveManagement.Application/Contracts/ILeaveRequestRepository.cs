﻿using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approved);
    }
}
