using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers
{
    public class GetUnitByIdHandler : IRequestHandler<GetUnitByIdQuery, UnitResponse>
    {
        public async Task<UnitResponse> Handle(GetUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}