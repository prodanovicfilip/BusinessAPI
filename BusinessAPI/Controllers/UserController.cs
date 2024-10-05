﻿using BusinessAPI.DTOs;
using BusinessAPI.Entities;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly BusinessDbContext _context;
        public UserController(BusinessDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var output = _context.Users.ToList();
                if (output.Any())
                {
                    return Ok(output);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var output = _context.Users.Where(u => u.Id == id).FirstOrDefault();
                if (output == null)
                {
                    return NotFound();
                }
                return Ok(output);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost("{id}")]
        public IActionResult Update([FromBody] UserDTO model, int id)
        {
            try
            {
                if (model == null || id <= 0)
                {
                    return BadRequest();
                }
                var user = _context.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return BadRequest();
                }
                model.Adapt(user);
                _context.Users.Update(user);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
                if (user == null)
                {
                    return BadRequest();
                }
                _context.Users.Remove(user);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public IActionResult Create([FromBody] UserDTO model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }
                var dbUser = _context.Users
                                     .Where(u => u.Username == model.Username)
                                     .FirstOrDefault();
                if (dbUser != null)
                {
                    return BadRequest();
                }
                var user = model.Adapt<User>();
                _context.Users.Add(user);
                _context.SaveChanges();
                return Created();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
