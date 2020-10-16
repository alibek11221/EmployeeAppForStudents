using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.UnitCommands;
using EmployeeAppWebApiDataBaseLibrary.Models;
using EmployeeAppWebApiDataBaseLibrary.Services;
using MediatR;
using Unit = EmployeeAppWebApiDataBaseLibrary.Models.Unit;

namespace EmployeeAppWebApi.MediatR.Handlers.CommandHandlers.UnitCommandHandlers
{
    public class CreateUnitHandler : IRequestHandler<CreateUnitCommand, GetUnitResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;

        public CreateUnitHandler(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
        }

        public async Task<GetUnitResponse> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            var mappedUnit = _mapper.Map<CreateUnitCommand, Unit>(request);
            var created = await _unitService.CreateAsync(mappedUnit, cancellationToken);
            return _mapper.Map<Unit, GetUnitResponse>(created);
        }
    }
}