using System;
using AutoMapper;
using DDD.Application.ViewModels;
using DDD.Domain.Models;

namespace DDD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Student, StudentViewModel>()
               .ForMember(d => d.County, o => o.MapFrom(s => s.Address.County))
               .ForMember(d => d.Province, o => o.MapFrom(s => s.Address.Province))
               .ForMember(d => d.City, o => o.MapFrom(s => s.Address.City))
                .ForMember(d => d.Street, o => o.MapFrom(s => s.Address.Street));
        }
    }
}
