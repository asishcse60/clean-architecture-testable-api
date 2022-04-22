using HRLeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>, IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
