using System.Linq;
using System.Threading.Tasks;
using Kubota.Infastructure;
using Microsoft.AspNetCore.Mvc;

namespace Kubota.Controllers
{
    [Route("api/[controller]")]
    public class HomeApiController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeApiController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET
        [HttpGet(nameof(GetData))]
        public async Task<IActionResult> GetData()
        {
            var data = _dbContext.Products.ToList();
            return Ok(data);
        }
    }
}