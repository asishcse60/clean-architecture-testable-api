using AutoMapper;
using HRLeaveManagement.Application.Contracts;
using HRLeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HRLeaveManagement.Domain;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand command, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<LeaveType>(command.LeaveTypeDto);
            leaveType = await _leaveTypeRepository.AddAsync(leaveType);
            return leaveType.Id;
        }
    }
}
