using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Contracts.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.CommandHandlers
{
    public class CreateUnitHandler : IRequestHandler<CreateUnitCommand, UnitResponse>
    {
        public async Task<UnitResponse> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}