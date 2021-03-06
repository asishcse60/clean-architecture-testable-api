using AutoMapper;
using HRLeaveManagement.Application.Contracts;
using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Application.DTOs;
using HRLeaveManagement.Application.DTOs.LeaveAllocation;
using HRLeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListDetailRequestHandler: IRequestHandler<GetLeaveAllocationListDetailRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationListDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocations = _leaveAllocationRepository.GetLeaveAllocationWithDetailsAsync();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
        }
    }
}
