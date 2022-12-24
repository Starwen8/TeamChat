using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Enities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    
    [Authorize]
    public class UserController : BaseApiController
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
            
        }
        [AllowAnonymous]
        //get list of user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser(){
            var users = await _context.Users.ToListAsync();
            
            return users;
        }

        //get user by Id 
        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>> GetUser(int id){
            return await _context.Users.FindAsync(id);
        }
        
    }
}