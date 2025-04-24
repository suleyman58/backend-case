using backend_case.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend_case.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductsController(ProductDbContext context)
        {
            _context = context;
        }



        //  GetAll: api/products
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        //  GetById : api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        //  Post : api/products
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateDto dto)
        {
            var product = new Product
            {
                ProductStatusId = dto.ProductStatusId,
                ProductStatusName = dto.ProductStatusName,
                ProductUrl = dto.ProductUrl,
                Title = dto.Title,
                TitleDomestic = dto.TitleDomestic,
                DescriptionDomestic = dto.DescriptionDomestic,
                Sku = dto.Sku,
                Barcode = dto.Barcode,
                OtherCode = dto.OtherCode,
                Stock = dto.Stock,
                CurrencyName = dto.CurrencyName,
                Price = dto.Price,
                PriceDiscountedDomestic = dto.PriceDiscountedDomestic,
                PriceDiscounted = dto.PriceDiscounted,
                IsFeatured = dto.IsFeatured,
                IsElonkyFeatured = dto.IsElonkyFeatured,
                HasVideo = dto.HasVideo,
                HasPersonalization = dto.HasPersonalization,
                IsTaxable = dto.IsTaxable,
                WhenMade = dto.WhenMade,
                WhoMade = dto.WhoMade,
                PersonalizationDescription = dto.PersonalizationDescription,
                IsDigital = dto.IsDigital
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        //  Put: api/products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] Product product)
        {
            if (id != product.Id)
                return BadRequest();

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        //  Delete : api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
