﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands
{
    public class UpdatePermissionForManagerCommand
    {
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        private string approvalStatus;

        public string ApprovalStatus
        {
            get 
            {
                if (IsApproved == true)
                {
                    approvalStatus = "Approved";
                }
                else
                {
                    approvalStatus = "Rejected";
                }
                return approvalStatus; 
            }
            
        }

    }
}