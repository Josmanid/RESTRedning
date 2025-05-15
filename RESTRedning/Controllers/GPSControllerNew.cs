using Microsoft.AspNetCore.Mvc;
using RESTRedning.Models;
using RESTRedning.Repositories;

namespace RESTRedning.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GPSControllerNew : ControllerBase
    {

        public readonly GPSDataDbRep _GPSDbRepo;

        public GPSControllerNew(GPSDataDbRep GPSDataDbRep)
        {
            _GPSDbRepo = GPSDataDbRep;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // GET: api/<GPSController>
        [HttpGet]
        public ActionResult<IEnumerable<GPSData>> Get()
        {
            IEnumerable<GPSData> result = _GPSDbRepo.GetGPSData();

            if (result.Any())
            {
                return Ok(result);
            }
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // POST api/<GPSController>
        [HttpPost]
        public ActionResult<GPSData> Post([FromBody] GPSData newGPSData)
        {
            try
            {
                GPSData createdGPSData = _GPSDbRepo.AddGPSData(newGPSData);
                return Created("/" + createdGPSData.Id, createdGPSData);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest("GPS data cannot be null: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("GPS is not valid!:" + ex.Message);
            }

        }
    }
}
