using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly DataContext _config;

        public AppUserController(DataContext config) {
            this._config = config;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAllAppUsers() {
            return await _config.AppUsers.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetAppuserById(int Id) {
            return await _config.AppUsers.FindAsync(Id);
        }
    }
}