using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerProject.API.DTOs;
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
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _PersonService;
        private readonly IMapper _mapper;
        public PersonsController(IService<Person> _PersonService,IMapper _mapper)
        {
            this._PersonService = _PersonService;
            this._mapper = _mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _PersonService.GetAllAsync();
            return Ok(persons);
        }
        [HttpPost]
        public async Task<IActionResult> Save(PersonDto person)
        {
            var Newperson = await _PersonService.AddAsync(_mapper.Map<Person>(person));

            return Created(string.Empty,_mapper.Map<PersonDto>(Newperson));
        }
    }
}
