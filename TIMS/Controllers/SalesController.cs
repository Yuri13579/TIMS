using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TIMS.DTO;
using TIMS.Models;
using TIMS.Service.Implements;
using TIMS.Service.Interfaces;

namespace TIMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SalesController(
            ISaleService saleService)
        {
            _saleService = saleService;
        }

        // GET: api/ProductImages/5
        [HttpGet("{portal}")]
        public async Task<List<ProductPortalDto>> GetProductImage(int id)
        {
            var products = await _saleService.GetPortalProducts();
            
            return products;
        }
    }
}
