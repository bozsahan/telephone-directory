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
                    UUID = 1,
                    Name ="şahan",
                    Surname ="boz",
                    Company="Okul"
                }

            };
        [HttpGet]
        public async Task<ActionResult<List<TelephoneDirectory>>> Get()
        {
            
            return Ok(directorys);
        }
        [HttpGet]
        public async Task<ActionResult<TelephoneDirectory>> Get(int UUID)
        {

            var directory = directorys.Find(x => x.UUID == UUID);
            if (directory == null)
                return BadRequest("People Not Found");
            return Ok(directory);
        }
        [HttpPost]
        public async Task<ActionResult<List<TelephoneDirectory>>> Post(TelephoneDirectory directory)
        {
            directorys.Add(directory);
            return Ok(directorys);
        }
    }
}
