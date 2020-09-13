using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers
{
    public class GetUnitByIdHandler : IRequestHandler<GetUnitByIdQuery, GetUnitResponse>
    {
        public async Task<GetUnitResponse> Handle(GetUnitByIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}