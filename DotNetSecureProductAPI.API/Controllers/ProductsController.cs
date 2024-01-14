using DotNetSecureProductAPI.Api.Interfaces;
using DotNetSecureProductAPI.Api.Models;
using DotNetSecureProductAPI.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetSecureProductAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private UserService _userService;
        private IProductRepository _productRepository;

        public ProductsController(UserService prUserService, IProductRepository prProductRepository)
        {
            _userService = prUserService;
            _productRepository = prProductRepository;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_productRepository.GetAll());
        }


        [HttpGet("bycolour")]
        [Produces("application/json")]
        [Authorize]
        public async Task<IActionResult> GetProductsByColour(string prColour)
        {
            return Ok(_productRepository.GetByColour(prColour));
        }
    }
}