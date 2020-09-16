using AutoMapper;
using EmployeeAppWebApi.Contracts.V1.Dtos.Response;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi.Profiles
{
    public class PositionMapProfiles : Profile
    {
        public PositionMapProfiles()
        {
            CreateMap<Position, GetPositionResponse>();
        }
    }
}