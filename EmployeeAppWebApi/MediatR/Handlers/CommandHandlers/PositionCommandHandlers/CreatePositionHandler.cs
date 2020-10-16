using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.PositionCommands;
using EmployeeAppWebApiDataBaseLibrary.Models;
using EmployeeAppWebApiDataBaseLibrary.Services;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.CommandHandlers.PositionCommandHandlers
{
    public class CreatePositionHandler : IRequestHandler<CreatePositionCommand, GetPositionResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPositionService _positionService;

        public CreatePositionHandler(IPositionService positionService, IMapper mapper)
        {
            _positionService = positionService;
            _mapper = mapper;
        }

        public async Task<GetPositionResponse> Handle(CreatePositionCommand request,
            CancellationToken cancellationToken)
        {
            var mappedPosition = _mapper.Map<CreatePositionCommand, Position>(request);
            var created = await _positionService.CreateAsync(mappedPosition, cancellationToken);
            return _mapper.Map<Position, GetPositionResponse>(created);
        }
    }
}