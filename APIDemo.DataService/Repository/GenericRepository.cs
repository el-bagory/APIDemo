using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.DataService.Data;
using APIDemo.DataService.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace APIDemo.DataService.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        internal DbSet<T> _dbSet;
        protected ILogger _logger;

        public GenericRepository
        (
            ApplicationDbContext context,
            ILogger logger
        )
        {
            _context = context;
            _logger = logger;
            _dbSet = context.Set<T>();
        }
        public virtual async Task<bool> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<bool> Delete(Guid id, string UserId)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetByID(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}