﻿using EmployeeAppWebApi.Data;
using EmployeeAppWebApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeAppWebApi.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<DataContext>(x =>
                x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitService, UnitService>();
        }
    }
}