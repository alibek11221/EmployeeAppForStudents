using System;
using EmployeeAppWebApi.Contracts.Dtos.Response;
using MediatR;

namespace EmployeeAppWebApi.MediatR.Queries
{
    public class GetUnitByIdQuery : IRequest<UnitResponse>
    {
        public Guid Id { get;  }

        public GetUnitByIdQuery(Guid id)
        {
            id = Id;
        }
        
    }
}