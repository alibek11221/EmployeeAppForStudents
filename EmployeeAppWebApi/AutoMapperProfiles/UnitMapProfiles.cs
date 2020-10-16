using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.UnitCommands;
using EmployeeAppWebApiDataBaseLibrary.Models;

namespace EmployeeAppWebApi.AutoMapperProfiles
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