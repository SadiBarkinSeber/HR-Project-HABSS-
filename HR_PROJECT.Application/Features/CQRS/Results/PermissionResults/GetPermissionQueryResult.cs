﻿using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.PermissionResults
{
    public class GetPermissionQueryResult
    {
        public int Id { get; set; }
        public string PermissionType { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? NumberOfDays { get; set; }
        public string? FileName { get; set; }
        public string ApprovalStatus { get; set; } = "Onay bekleniyor";
        public string EmployeeFirstName { get; set; }
        public string EmployeeSecondName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeSecondLastName { get; set; }
        public int? EmployeeId { get; set; }
        public bool? IsApproved { get; set; }
    }
}
