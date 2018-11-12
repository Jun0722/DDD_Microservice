using System;
using AutoMapper;
using DDD.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.Web.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection servers)
        {
            if(servers==null)
            {
                throw new ArgumentNullException(nameof(servers));
            }
            servers.AddAutoMapper();
            AutoMapperConfig.RegisterMappings();
        }
    }
}
