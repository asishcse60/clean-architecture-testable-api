using AutoMapper;
using HRLeaveManagement.Application.DTOs;
using HRLeaveManagement.Application.DTOs.LeaveAllocation;
using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Application.DTOs.LeaveType;
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Configurations
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
