using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries.UnitQueries;
using EmployeeAppWebApi.Services;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers.UnitQueryHandlers
{
    public class GetUnitByIdHandler : IRequestHandler<GetUnitByIdQuery, GetUnitResponse>
    {
        private readonly IUnitService _unitService;
        private readonly IMapper _mapper;

        public GetUnitByIdHandler(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
        }

        public async Task<GetUnitResponse> Handle(GetUnitByIdQuery request, CancellationToken cancellationToken)
        {
            var unit = await _unitService.GetByIdAsync(request.Id, cancellationToken);
            return _mapper.Map<Models.Unit, GetUnitResponse>(unit);
        }
    }
}