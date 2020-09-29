using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TIMS.Context;
using TIMS.Models;

namespace TIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOnHandsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ProductOnHandsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ProductOnHands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductOnHand>>> GetProductOnHands()
        {
            return await _context.ProductOnHands.ToListAsync();
        }

        // GET: api/ProductOnHands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductOnHand>> GetProductOnHand(int id)
        {
            var productOnHand = await _context.ProductOnHands.FindAsync(id);

            if (productOnHand == null)
            {
                return NotFound();
            }

            return productOnHand;
        }

        // PUT: api/ProductOnHands/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductOnHand(int id, ProductOnHand productOnHand)
        {
            if (id != productOnHand.ProductOnHandId)
            {
                return BadRequest();
            }

            _context.Entry(productOnHand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductOnHandExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductOnHands
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductOnHand>> PostProductOnHand(ProductOnHand productOnHand)
        {
            _context.ProductOnHands.Add(productOnHand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductOnHand", new { id = productOnHand.ProductOnHandId }, productOnHand);
        }

        // DELETE: api/ProductOnHands/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductOnHand>> DeleteProductOnHand(int id)
        {
            var productOnHand = await _context.ProductOnHands.FindAsync(id);
            if (productOnHand == null)
            {
                return NotFound();
            }

            _context.ProductOnHands.Remove(productOnHand);
            await _context.SaveChangesAsync();

            return productOnHand;
        }

        private bool ProductOnHandExists(int id)
        {
            return _context.ProductOnHands.Any(e => e.ProductOnHandId == id);
        }
    }
}
