using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Results.AdvanceResults;
using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.Domain.Entities;

namespace HR_PROJECT.WebAPI.HelperFunctions
{
    public class CheckEmployeeWage
    {
        private readonly GetEmployeeByIdQueryHandler _getEmployeeById;
        public CheckEmployeeWage(GetEmployeeByIdQueryHandler getEmployeeById)
        {
            _getEmployeeById = getEmployeeById;
        }

        

        public async Task<bool> Helper(GetEmployeeByIdQuery query, decimal requestedAmount)
        {
            GetEmployeeByIdQueryResult result = await _getEmployeeById.Handle(query);

            if (requestedAmount > (result.Wage * 3))
            {
                return false;
            }

            return true;
        }

    }
}
