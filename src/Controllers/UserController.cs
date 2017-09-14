using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreDocker.Controllers
{
    [Route("api/User")]
    public class UserController : Controller
    {
         [HttpGet]
        public IActionResult Get(int IdArquivo)
        {
            return Ok(new List<string>(){
               "Guilherme Baldini",
               "João Salles",
               "Anderson Vitorino",
               "Fabricio Hilario"
            });
        }
    }
}
