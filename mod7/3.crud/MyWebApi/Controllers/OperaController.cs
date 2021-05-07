using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperaController : ControllerBase
    {
        [HttpGet]
        public Opera Get()
        {
            Opera myOpera = new Opera
            {
                OperaID = 1,
                Title = "TEST",
                Composer = "123"
            };

            return myOpera;
        }

    }
}
