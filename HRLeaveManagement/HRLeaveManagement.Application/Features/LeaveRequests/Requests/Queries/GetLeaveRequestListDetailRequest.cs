using HRLeaveManagement.Application.DTOs;
using HRLeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListDetailRequest: IRequest<List<LeaveRequestDto>>
    {
    }
}
