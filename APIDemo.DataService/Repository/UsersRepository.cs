using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.DataService.Data;
using APIDemo.DataService.IRepository;
using APIDemo.Entities.DbSet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace APIDemo.DataService.Repository
{
    public class UsersRepository : GenericRepository<User>, IUsersRepository
    {
        public UsersRepository
        (
            ApplicationDbContext context, 
            ILogger logger
        ) : base(context, logger)
        {
        }

        public override async Task<IEnumerable<User>> All()
        {
            try
            {
                return await _dbSet.Where(a => a.Status == 1).AsNoTracking().ToListAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method has generated an error",typeof(UsersRepository));
                return new List<User>();
            }
        }
        



    }
}