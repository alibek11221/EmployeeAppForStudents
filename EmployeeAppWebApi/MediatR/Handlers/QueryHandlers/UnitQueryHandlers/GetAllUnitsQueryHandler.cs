using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries.UnitQueries;
using EmployeeAppWebApiDataBaseLibrary.Models;
using EmployeeAppWebApiDataBaseLibrary.Services;
using MediatR;
using Unit = EmployeeAppWebApiDataBaseLibrary.Models.Unit;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers.UnitQueryHandlers
{
    public class GetAllUnitsQueryHandler : IRequestHandler<GetAllUnitsQuery, List<GetUnitResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;

        public GetAllUnitsQueryHandler(IMapper mapper, IUnitService unitService)
        {
            _mapper = mapper;
            _unitService = unitService;
        }

        public async Task<List<GetUnitResponse>> Handle(GetAllUnitsQuery request, CancellationToken cancellationToken)
        {
            var units = await _unitService.GetAllAsync(cancellationToken);
            return units.Select(x => _mapper.Map<Unit, GetUnitResponse>(x)).ToList();
        }
    }
}