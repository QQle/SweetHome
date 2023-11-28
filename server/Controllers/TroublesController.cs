using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swetHome.Context;

namespace swetHome.Controllers
{
	public class TroublesController : Controller
	{
		public static readonly HttpClient client = new HttpClient();
		public readonly TroublesContextDb _troublescontextDb;

		public TroublesController(TroublesContextDb troublescontextDatabase)
		{
			_troublescontextDb = troublescontextDatabase;

		}
		[HttpGet]
		[Route("Troubles")]
		public async Task<IActionResult> AllTroubles(int _limitTr, int pageTr = 1)
		{




			if (_limitTr <= 0 || pageTr <= 0)
			{

				return Ok(await _troublescontextDb.Troubles!.ToListAsync());
			}
			var result1 = await _troublescontextDb.Troubles!
				  .OrderBy(x => x.TroublesId)
				  .Take(pageTr * _limitTr)
					 .ToListAsync();



			return Ok(result1);





		}
	}
}
