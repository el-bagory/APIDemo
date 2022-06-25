using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Entities.DTO;
using APIDemo.DataService.Data;
using APIDemo.Entities.DbSet;
using Microsoft.AspNetCore.Mvc;
using APIDemo.DataService.IConfiguration;

namespace APIDemo.API.Controllers.V1
{
    public class UsersController : BaseController
    {

        public UsersController(IUnitOfWork unitofwork) : base (unitofwork)
        {
        }

        // get all
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var data = await _unitofwork.Users.All();
            return Ok(data);
        }

        // post
        [HttpPost]
        public async Task<IActionResult> AddUser(UserDTO user)
        {
            var _user = new User();
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.Email = user.Email;
            _user.Country = user.Country;
            _user.DateOfBirth  =Convert.ToDateTime( user.DateOfBirth );
            _user.Status = 1;
            _user.Phone = user.Phone;

            await _unitofwork.Users.Add(_user);
            await _unitofwork.CompleteAsync();
            // _context.Users.Add(_user);
            // _context.SaveChanges();
            return CreatedAtRoute("GetUser",new{ id = _user.Id}, user);
        }

        // get user
        [HttpGet]
        [Route("GetUser", Name = "GetUser")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            // var user = _context.Users.FirstOrDefault(a => a.Id == id);
            var user = await _unitofwork.Users.GetByID(id);
            return Ok(user);
        }
        
    }
}