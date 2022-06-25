using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.DataService.IRepository;

namespace APIDemo.DataService.IConfiguration
{
    public interface IUnitOfWork
    {
        IUsersRepository Users{get ; set; }
        Task CompleteAsync();
    }
}