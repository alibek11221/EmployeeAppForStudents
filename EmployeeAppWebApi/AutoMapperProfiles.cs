using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Unit, GetUnitResponse>();
            CreateMap<CreateUnitRequest, CreateUnitCommand>();
            CreateMap<CreateUnitCommand, Unit>();
        }
    }
}