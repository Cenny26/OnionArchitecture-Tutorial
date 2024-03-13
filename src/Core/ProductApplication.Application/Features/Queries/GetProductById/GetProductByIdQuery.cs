using AutoMapper;
using MediatR;
using ProductApplication.Application.DTOs;
using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Application.Wrappers;

namespace ProductApplication.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdDto>>
    {
        public Guid Id { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdDto>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<GetProductByIdDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var product = await _productRepository.GetByIdAsync(request.Id);
                var dto = _mapper.Map<GetProductByIdDto>(product);

                return new ServiceResponse<GetProductByIdDto>(dto);
            }
        }
    }
}
