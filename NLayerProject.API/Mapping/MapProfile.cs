using AutoMapper;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryWithProductDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<ProductWithCategoryDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();

        }
    }
}
