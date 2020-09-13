using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands;
using EmployeeAppWebApi.Services;
using MediatR;
using Unit = EmployeeAppWebApi.Models.Unit;

namespace EmployeeAppWebApi.MediatR.Handlers.CommandHandlers
{
    public class CreateUnitHandler : IRequestHandler<CreateUnitCommand, GetUnitResponse>
    {
        private readonly IUnitService _unitService;
        private readonly IMapper _mapper;

        public CreateUnitHandler(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
        }

        public async Task<GetUnitResponse> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            var mappedUnit = _mapper.Map<CreateUnitCommand, Unit>(request);
            var created = await _unitService.CreateUnitAsync(mappedUnit, cancellationToken);
            return _mapper.Map<Unit, GetUnitResponse>(created);
        }
    }
}