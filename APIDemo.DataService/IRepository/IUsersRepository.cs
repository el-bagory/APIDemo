using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Entities.DbSet;

namespace APIDemo.DataService.IRepository
{
    public interface IUsersRepository : IGenericRepository<User>
    {
        // Task<User> GetUserByEmail(string Email);
    }
}