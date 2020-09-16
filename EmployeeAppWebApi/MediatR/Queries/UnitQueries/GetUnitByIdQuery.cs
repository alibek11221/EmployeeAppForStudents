using System;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries.UnitQueries
{
    public class GetUnitByIdQuery : IRequest<GetUnitResponse>
    {
        public Guid Id { get; }

        public GetUnitByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}