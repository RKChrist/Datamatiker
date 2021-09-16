using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add")]
        [Produces("application/xml")]
        public IActionResult Add(int a, int b)
        {
            return Ok(a + b);
        }
        [HttpGet("Subtract")]
        public IActionResult Subtract(int a, int b)
        {
            var problem = new { 
            Status = (int)HttpStatusCode.InternalServerError, 
            Response = "The record you attempted to delete "
            + "was modified by another user after you got the original values. "
            + "The delete operation was canceled and the current values in the "
            + "database have been displayed."
            };

        return StatusCode(problem.Status, problem);
           // return Ok(a - b);
        }
       

        //GET download/12345abc
        [HttpGet("Download/{id}")]
        public async Task<IActionResult> Download(string id)
        {
            Stream stream = new MemoryStream(Encoding.ASCII.GetBytes("Hello World"));
           // Stream stream = await { { __get_stream_based_on_id_here__} }
            // var path = Path.Combine("/", "Diploma.txt");
           
            if (stream == null)
                return NotFound(); 
            
            return File(stream, "text/plain", "Diploma.txt"); 
        }

    }
}