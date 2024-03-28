using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Queries.SiteManagetQueries
{
    public class GetSiteManagerByIdQuery
    {
        public GetSiteManagerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
