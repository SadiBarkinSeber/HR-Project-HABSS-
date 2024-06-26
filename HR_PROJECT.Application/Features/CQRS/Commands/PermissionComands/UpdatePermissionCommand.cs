﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands
{
    public class UpdatePermissionCommand
    {
        public int Id { get; set; }
        public string PermissionType { get; set; }
        public DateTime RequestDate { get; } = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? NumberOfDays { get; set; }
        public string? FileName { get; set; }
        public string ApprovalStatus { get; set; } 
        public int? EmployeeId { get; set; }

    }
}
