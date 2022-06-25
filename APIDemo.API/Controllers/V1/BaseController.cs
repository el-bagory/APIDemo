using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.DataService.IConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.API.Controllers.V1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class BaseController : ControllerBase
    {
        protected readonly IUnitOfWork _unitofwork;

        public BaseController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
    }
}