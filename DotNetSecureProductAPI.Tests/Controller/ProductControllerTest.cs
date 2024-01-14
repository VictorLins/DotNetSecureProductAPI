using DotNetSecureProductAPI.Api.Controllers;
using DotNetSecureProductAPI.Api.Interfaces;
using DotNetSecureProductAPI.Api.Services;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace DotNetSecureProductAPI.Tests.Controller
{
    public class ProductControllerTest : IClassFixture<WebApplicationFactory<Program>>
    {
        private UserService _userService;
        private IProductRepository _productRepository;
        private readonly WebApplicationFactory<Program> _factory;

        public ProductControllerTest(WebApplicationFactory<Program> prFactory)
        {
            _userService = A.Fake<UserService>();
            _productRepository = A.Fake<IProductRepository>();
            _factory = prFactory;
        }

        // Unit Test
        [Fact]
        public async void ProductController_GetProducts_ReturnOK()
        {
            // Arrange
            ProductsController lProductsController = new ProductsController(_userService, _productRepository);

            // Act
            var lResult = await lProductsController.GetAll();

            // Assert
            lResult.Should().NotBeNull();
            lResult.Should().BeOfType(typeof(OkObjectResult));
        }

        // Integration Test
        [Fact]
        public async void ProductController_GetProducts_Authorized()
        {
            // Arrange
            HttpClient lHttpClient = _factory.CreateClient();
            lHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJFbWFpbCI6ImluZm9AdmljdG9yLm5ldCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWVpZGVudGlmaWVyIjoiNzNlNWI4N2EtNzQ4My00ZjRjLTg3MmMtOTdjOTBlZmYwOGUxIiwiZXhwIjoxNzA3Nzg5MzE2LCJpc3MiOiJodHRwOi8vRG90TmV0U2VjdXJlUHJvZHVjdEFQSS5pc3N1ZXIiLCJhdWQiOiJodHRwOi8vRG90TmV0U2VjdXJlUHJvZHVjdEFQSS5hdWRpZW5jZSJ9.3vKhHHd9m5cAZiHJ4AFHrmaPKKap6lLbw_7HrvPUXdE");

            // Act
            HttpResponseMessage lHttpResponseMessage = await lHttpClient.GetAsync("/api/products");

            // Assert
            Assert.Equal(HttpStatusCode.OK, lHttpResponseMessage.StatusCode);
        }

        // Integration Test
        [Fact]
        public async void ProductController_GetProducts_NotAuthorized()
        {
            // Arrange
            HttpClient lHttpClient = _factory.CreateClient();

            // Act
            HttpResponseMessage lHttpResponseMessage = await lHttpClient.GetAsync("/api/products");

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, lHttpResponseMessage.StatusCode);
        }

        // Unit Test
        [Fact]
        public async void ProductController_GetProductsByColour_ReturnOK()
        {
            // Arrange
            string lColour = "Red";
            ProductsController lProductsController = new ProductsController(_userService, _productRepository);

            // Act
            var lResult = await lProductsController.GetProductsByColour(lColour);

            // Assert
            lResult.Should().NotBeNull();
            lResult.Should().BeOfType(typeof(OkObjectResult));
        }

        // Integration Test
        [Fact]
        public async void ProductController_GetProductsByColour_Authorized()
        {
            // Arrange
            HttpClient lHttpClient = _factory.CreateClient();
            lHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJFbWFpbCI6ImluZm9AdmljdG9yLm5ldCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWVpZGVudGlmaWVyIjoiNzNlNWI4N2EtNzQ4My00ZjRjLTg3MmMtOTdjOTBlZmYwOGUxIiwiZXhwIjoxNzA3Nzg5MzE2LCJpc3MiOiJodHRwOi8vRG90TmV0U2VjdXJlUHJvZHVjdEFQSS5pc3N1ZXIiLCJhdWQiOiJodHRwOi8vRG90TmV0U2VjdXJlUHJvZHVjdEFQSS5hdWRpZW5jZSJ9.3vKhHHd9m5cAZiHJ4AFHrmaPKKap6lLbw_7HrvPUXdE");

            // Act
            HttpResponseMessage lHttpResponseMessage = await lHttpClient.GetAsync("/api/products/bycolour?prColour=Red");

            // Assert
            Assert.Equal(HttpStatusCode.OK, lHttpResponseMessage.StatusCode);
        }

        // Integration Test
        [Fact]
        public async void ProductController_GetProductsByColour_NotAuthorized()
        {
            // Arrange
            HttpClient lHttpClient = _factory.CreateClient();

            // Act
            HttpResponseMessage lHttpResponseMessage = await lHttpClient.GetAsync("/api/products/bycolour");

            // Assert
            Assert.Equal(HttpStatusCode.Unauthorized, lHttpResponseMessage.StatusCode);
        }
    }
}