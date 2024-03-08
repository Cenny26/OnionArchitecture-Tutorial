using Microsoft.AspNetCore.Mvc;
using ProductApplication.Application.DTOs;
using ProductApplication.Application.Interfaces.Repository;

namespace ProductApplication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await _productRepository.GetAllAsync();
            var result = allList.Select(i => new ProductViewDto()
            {
                Id = i.Id,
                Name = i.Name,
                Value = i.Value
            });

            return Ok(result);
        }
    }
}
