using System.Collections.Generic;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries
{
    public class GetAllUnitsQuery : IRequest<List<GetUnitResponse>>
    {
    }
}