using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.DataService.IConfiguration;
using APIDemo.DataService.IRepository;
using APIDemo.DataService.Repository;
using Microsoft.Extensions.Logging;

namespace APIDemo.DataService.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        public IUsersRepository Users { get; set; }


        public UnitOfWork
        (
            ApplicationDbContext context,
            ILoggerFactory loggerFactory
        )
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("db_logs"); 
            Users = new UsersRepository(context, _logger);
        }


        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
}