using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries
{
    public class GetAdvancesByEmployeeIdQuery
    {

        public GetAdvancesByEmployeeIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
