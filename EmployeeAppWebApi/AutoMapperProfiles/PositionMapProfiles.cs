using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Request;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.MediatR.Commands.PositionCommands;
using EmployeeAppWebApiDataBaseLibrary.Models;

namespace EmployeeAppWebApi.AutoMapperProfiles
{
    public class PositionMapProfiles : Profile
    {
        public PositionMapProfiles()
        {
            CreateMap<Position, GetPositionResponse>();
            CreateMap<CreatePositionRequest, CreatePositionCommand>();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}