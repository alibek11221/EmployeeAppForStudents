

using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Queries.UnitQueries;
using EmployeeAppWebApiDataBaseLibrary.Services;
using MediatR;
using Unit = EmployeeAppWebApiDataBaseLibrary.Models.Unit;

namespace EmployeeAppWebApi.MediatR.Handlers.QueryHandlers.UnitQueryHandlers
{
    public class GetUnitByIdHandler : IRequestHandler<GetUnitByIdQuery, GetUnitResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitService _unitService;

        public GetUnitByIdHandler(IUnitService unitService, IMapper mapper)
        {
            _unitService = unitService;
            _mapper = mapper;
        }

        public async Task<GetUnitResponse> Handle(GetUnitByIdQuery request, CancellationToken cancellationToken)
        {
            var unit = await _unitService.GetByIdAsync(request.Id, cancellationToken);
            return _mapper.Map<Unit, GetUnitResponse>(unit);
        }
    }
}