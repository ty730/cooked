using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class IngredientController : ControllerBase
    {
         private readonly AppDbContext _context;
        public IngredientController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id) {
            var user = _context.Users.Find(id);
            if (user == null) {
                return NotFound();
            }
            return Ok(user);
        }
    }
}