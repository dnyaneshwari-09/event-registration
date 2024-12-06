using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventManagementAPI.Models;
using EventManagementAPI.Models.DTOs;
using EventManagementAPI.Repositories;
using AutoMapper;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private readonly IRegistrationRepository _repository;
        private readonly IMapper _mapper;

        public RegistrationsController(IRegistrationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrationDto>>> GetAll()
        {
            var registrations = await _repository.GetAllAsync();
            var registrationDtos = _mapper.Map<IEnumerable<RegistrationDto>>(registrations);
            return Ok(registrationDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RegistrationDto>> GetById(Guid id)
        {
            var registration = await _repository.GetByIdAsync(id);
            if (registration == null)
                return NotFound();

            var registrationDto = _mapper.Map<RegistrationDto>(registration);
            return Ok(registrationDto);
        }

        [HttpPost]
        public async Task<ActionResult<RegistrationDto>> Create(RegistrationDto registrationDto)
        {
            var registration = _mapper.Map<Registration>(registrationDto);
            await _repository.AddAsync(registration);
            var createdRegistrationDto = _mapper.Map<RegistrationDto>(registration);

            return CreatedAtAction(nameof(GetById), new { id = createdRegistrationDto.RegistrationId }, createdRegistrationDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, RegistrationDto registrationDto)
        {
            if (id != registrationDto.RegistrationId)
                return BadRequest();

            var registration = _mapper.Map<Registration>(registrationDto);
            await _repository.UpdateAsync(registration);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repository.DeleteAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
