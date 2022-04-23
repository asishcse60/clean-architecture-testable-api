﻿using HRLeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRLeaveManagement.Persistence.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
                new LeaveType
                {
                    Id = 1,
                    DefaultDays = 10,
                    Name = "Vacation",
                    CreatedBy = "Asish",
                    DateCreated = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    LastModifiedBy = "Asish"
                },
                new LeaveType
                {
                    Id = 2,
                    DefaultDays = 12,
                    Name = "Sick",
                    CreatedBy = "Asish",
                    DateCreated = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    LastModifiedBy = "Asish"
                }
            );
        }
    }
}
