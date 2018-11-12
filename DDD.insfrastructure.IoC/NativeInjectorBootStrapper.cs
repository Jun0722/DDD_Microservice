using System;
using DDD.Application.Interfaces;
using DDD.Application.Services;
using DDD.Domain.Interfaces;
using DDD.Insfrastructure.Data.Context;
using DDD.Insfrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.insfrastructure.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // 注入 Application 应用层
            services.AddScoped<IStudentAppService, StudentAppService>();


            // 注入 Infra - Data 基础设施数据层
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<StudyContext>();
        }
    }
}
