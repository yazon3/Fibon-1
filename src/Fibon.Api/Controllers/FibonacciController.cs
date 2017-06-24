using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    [Route("[controller]")]
    public class FibonacciController : Controller
    {
        [HttpGet("{number}")]
        public async Task<IActionResult> Get(int number)
        {
            await Task.CompletedTask;
            return Content(number.ToString());
        }

		[HttpPost("{number}")]
		public async Task<IActionResult> Post(int number)
		{
            await Task.CompletedTask;
            return Accepted($"fibonacci/{number}", null);
		}
    }
}
