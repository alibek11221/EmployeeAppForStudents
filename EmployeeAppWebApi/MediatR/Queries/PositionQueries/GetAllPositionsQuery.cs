using System.Collections.Generic;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries.PositionQueries
{
    public class GetAllPositionsQuery : IRequest<List<GetPositionResponse>>
    {
        
    }
}