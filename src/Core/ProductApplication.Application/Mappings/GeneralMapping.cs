using AutoMapper;
using ProductApplication.Application.DTOs;
using ProductApplication.Application.Features.Commands.CreateProduct;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Application.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();
        }
    }
}
