﻿using AutoMapper;
using SalesApi.Infrastructure.DomainModels;
using SalesApi.ViewModels.Settings;

namespace SalesApi.Web.Configurations
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}