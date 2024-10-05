using BusinessAPI.DTOs;
using BusinessAPI.Entities;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly BusinessDbContext _context;
        public ProductController(BusinessDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.ToList();
            var productsDTO = products.Adapt<IEnumerable<ProductDTO>>();
            return Ok(productsDTO);
        }
    }
}
