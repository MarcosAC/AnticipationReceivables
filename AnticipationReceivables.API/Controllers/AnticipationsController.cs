using Microsoft.AspNetCore.Mvc;

namespace AnticipationReceivables.API.Controllers
{
    [Route("api/anticipations")]
    public class AnticipationsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {            
            return Ok();
        }

        [HttpGet("status")]
        public IActionResult GetByStatus(string status)
        {
            return Ok();
        }

        [HttpPost()]        
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPost("{id}/installment")]
        public IActionResult PostInstallment(int id)
        {
            return Ok();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return Ok();
        }
    }
}
