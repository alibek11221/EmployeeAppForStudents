using System;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries
{
    public class GetUnitByIdQuery : IRequest<GetUnitResponse>
    {
        public Guid Id { get; }

        public GetUnitByIdQuery(Guid id)
        {
            id = Id;
        }
    }
}