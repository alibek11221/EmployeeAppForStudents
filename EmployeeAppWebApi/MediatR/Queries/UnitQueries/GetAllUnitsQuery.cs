using System.Collections.Generic;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries.UnitQueries
{
    public class GetAllUnitsQuery : IRequest<List<GetUnitResponse>>
    {
    }
}