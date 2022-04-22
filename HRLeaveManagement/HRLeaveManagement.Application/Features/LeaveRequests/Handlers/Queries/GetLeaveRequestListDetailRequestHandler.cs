using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRLeaveManagement.Application.Contracts;
using HRLeaveManagement.Application.DTOs;
using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListDetailRequestHandler : IRequestHandler<GetLeaveRequestListDetailRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetailsAsync();
            return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
        }
    }
}
