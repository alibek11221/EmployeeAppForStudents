using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers
{
    public class GetAllUnitsQueryHandler : IRequestHandler<GetAllUnitsQuery, List<UnitResponse>>
    {
        public async Task<List<UnitResponse>> Handle(GetAllUnitsQuery request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}