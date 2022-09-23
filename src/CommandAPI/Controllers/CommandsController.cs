using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
	[Route("api/[controller]")]  // semi-dynamically route from controller name without controller postfix
	// [Route("api/commands2")]  // hardcode static route
	[ApiController]
	public class CommandsController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "this", "is", "hard", "coded" };
		}
	}
}