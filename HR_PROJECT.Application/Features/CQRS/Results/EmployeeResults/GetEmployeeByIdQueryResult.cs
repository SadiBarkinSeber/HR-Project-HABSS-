using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults
{
    public class GetEmployeeByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
