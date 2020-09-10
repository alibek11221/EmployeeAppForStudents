using System.Collections.Generic;
using EmployeeAppWebApi.Contracts.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries
{
    public class GetAllUnitsQuery : IRequest<List<UnitResponse>>
    {
        
    }
}