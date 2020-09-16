using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi.Profiles
{
    public class UnitMapProfiles : Profile
    {
        public UnitMapProfiles()
        {
            CreateMap<Unit, GetUnitResponse>();
            CreateMap<CreateUnitRequest, CreateUnitCommand>();
            CreateMap<CreateUnitCommand, Unit>();
        }
    }
}