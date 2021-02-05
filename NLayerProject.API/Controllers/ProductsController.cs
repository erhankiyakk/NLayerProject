using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.API.DTOs;
using NLayerProject.API.Filters;
using NLayerProject.Core.Models;
using NLayerProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService _productService, IMapper _mapper)
        {
            this._productService =_productService;
            this._mapper = _mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(product));
        }
        [HttpGet("{id}/categories")]
        public async Task<IActionResult> GetWithCategoryByIdAsync(int id)
        {
            var product = await _productService.GetWithCategoryByIdAsync(id);
            return Ok(_mapper.Map<ProductWithCategoryDto>(product));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto ProductDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(ProductDto));
            return Created(string.Empty, _mapper.Map<ProductDto>(product));
        }
        [HttpPut]
        public IActionResult Update(ProductDto ProductDto)
        {
            var product = _productService.Update(_mapper.Map<Product>(ProductDto));
            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var product = _productService.GetByIdAsync(id).Result;
            _productService.Remove(product);

            return NoContent();
        }

    }
}
