using Microsoft.AspNetCore.Mvc;
using RESTRedning.RepositoryList;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTRedning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GPSController : ControllerBase
    {
        public readonly GPSDataRep _GPSDataRepo;

        public GPSController(GPSDataRep gPSDataRepo)
        {
            _GPSDataRepo = gPSDataRepo;
        }






        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // GET: api/<GPSController>
        [HttpGet]
        public IEnumerable<string> Get() 
        {
            return new string[] { "value1", "value2" };
        }

       

        // POST api/<GPSController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

    }
}
