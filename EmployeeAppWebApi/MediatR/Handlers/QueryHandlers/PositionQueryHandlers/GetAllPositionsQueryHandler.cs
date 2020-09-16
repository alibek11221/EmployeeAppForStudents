using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries.PositionQueries;
using EmployeeAppWebApi.Models;
using EmployeeAppWebApi.Services;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers.PositionQueryHandlers
{
    public class GetAllPositionsQueryHandler : IRequestHandler<GetAllPositionsQuery, List<GetPositionResponse>>
    {
        private readonly IPositionService _positionService;
        private readonly IMapper _mapper;

        public GetAllPositionsQueryHandler(IPositionService positionService, IMapper mapper)
        {
            _positionService = positionService;
            _mapper = mapper;
        }
        public async Task<List<GetPositionResponse>> Handle(GetAllPositionsQuery request, CancellationToken cancellationToken)
        {
            var positions = await _positionService.GetAllAsync(cancellationToken);
            return positions.Select(x => _mapper.Map<Position, GetPositionResponse>(x)).ToList();
        }
    }
}