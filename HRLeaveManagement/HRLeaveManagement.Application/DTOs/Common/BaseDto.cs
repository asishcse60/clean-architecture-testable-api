using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLeaveManagement.Application.DTOs.Common
{
    public class BaseDto
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
    }
}
