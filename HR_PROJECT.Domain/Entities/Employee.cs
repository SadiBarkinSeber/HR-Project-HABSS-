﻿using HR_PROJECT.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Employee : BaseEmployee
    {
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
