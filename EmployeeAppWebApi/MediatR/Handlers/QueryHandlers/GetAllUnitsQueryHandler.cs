using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries;
using EmployeeAppWebApi.Services;
using MediatR;
using Unit = EmployeeAppWebApi.Models.Unit;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers
{
    public class GetAllUnitsQueryHandler : IRequestHandler<GetAllUnitsQuery, List<GetUnitResponse>>
    {
        private readonly IUnitService _unitService;
        private readonly IMapper _mapper;

        public GetAllUnitsQueryHandler(IMapper mapper, IUnitService unitService)
        {
            _mapper = mapper;
            _unitService = unitService;
        }

        public async Task<List<GetUnitResponse>> Handle(GetAllUnitsQuery request, CancellationToken cancellationToken)
        {
            var units = await _unitService.GetUnitsAsync(cancellationToken);
            return units.Select(x => _mapper.Map<Unit, GetUnitResponse>(x)).ToList();
        }
    }
}