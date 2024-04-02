using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands
{
    public class CreatePermissionCommand
    {
        public CreatePermissionCommand()
        {
            RequestDate = DateTime.Now;
        }

        public string PermissionType { get; set; }

        public DateTime RequestDate { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private static readonly Dictionary<string, int> PermissionDays = new Dictionary<string, int>
        {
            { "Baba İzni", 5 },
            { "Anne İzni", 112 },
            { "Cenaze İzni", 3 },
            { "Evlilik İzni", 3 },
            { "Yıllık İzin", 15 }
        };
        private int numberOfDays;

        public int NumberOfDays
        {
            get { return numberOfDays; }
            set 
            { 
                int maxDays = PermissionDays[PermissionType];
                if (value <= maxDays)
                {
                    numberOfDays = value;
                }
                else
                {
                    numberOfDays = maxDays;
                }
            }
        }

        public string? FileName { get; set; }
        public string ApprovalStatus { get; } = "Talep Edildi";
        public int EmployeeId { get; set; }
    }
}
