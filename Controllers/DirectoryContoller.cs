using Directory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Directory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryContoller : ControllerBase
    {
      private static List<TelephoneDirectory> directorys= new List<TelephoneDirectory>
            {
                new TelephoneDirectory
                {
                    Name ="şahan",
                    Surname ="boz",
                    Company="Okul"
                }

            };
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            return Ok(directorys);
        }
    }
}
