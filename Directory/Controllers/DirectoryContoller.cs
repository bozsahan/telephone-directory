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
                },
                new TelephoneDirectory
                {

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
        [HttpGet("{UUID}")]
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
        [HttpPut]
        public async Task<ActionResult<List<TelephoneDirectory>>> Put(TelephoneDirectory request)
        {
            var directory = directorys.Find(x => x.UUID ==request.UUID);
            if (directory == null)
                return BadRequest("People Not Found");
            directory.Name = request.Name;
            directory.Surname = request.Surname;
            directory.Company = request.Company;
            return Ok(directorys);
        }
        [HttpDelete("{UUID}")]
        public async Task<ActionResult<List<TelephoneDirectory>>> Delete(int UUID)
        {

            var directory = directorys.Find(x => x.UUID == UUID);
            if (directory == null)
                return BadRequest("People Not Found");
            directorys.Remove(directory);
            return Ok(directory);
        }

    }
}
