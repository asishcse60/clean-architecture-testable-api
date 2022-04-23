﻿using System.Collections.Generic;
using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Domain;
using Moq;

namespace HRLeaveManagement.Application.UnitTests.Mocks
{
    public static class MockLeaveTypeRepository
    {
            public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
            {
                var leaveTypes = new List<LeaveType>
                {
                    new LeaveType
                    {
                        Id = 1,
                        DefaultDays = 10,
                        Name = "Test Vacation"
                    },
                    new LeaveType
                    {
                        Id = 2,
                        DefaultDays = 15,
                        Name = "Test Sick"
                    },
                    new LeaveType
                    {
                        Id = 3,
                        DefaultDays = 15,
                        Name = "Test Maternity"
                    }
                };

                var mockRepo = new Mock<ILeaveTypeRepository>();

                mockRepo.Setup(r => r.GetLeaveTypesWithDetailsAsync()).ReturnsAsync(leaveTypes);

                mockRepo.Setup(r => r.AddAsync(It.IsAny<LeaveType>())).ReturnsAsync((LeaveType leaveType) =>
                {
                    leaveTypes.Add(leaveType);
                    return leaveType;
                });

                return mockRepo;

            }
    }
}

