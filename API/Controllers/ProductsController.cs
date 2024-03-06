using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // this constructor allow this controller to use the context
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        // this endpoint get a list of products
        [HttpGet]
        public async Task<ActionResult<List<Product>>>GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // this endpoint get one product by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }


    }
}