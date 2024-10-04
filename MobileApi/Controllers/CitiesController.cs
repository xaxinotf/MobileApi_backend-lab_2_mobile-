using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileApi.Models;

namespace MobileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly MobileAppDbContext _context;

        public CitiesController(MobileAppDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-cities")]
        public async Task<ActionResult> GetCities()
        {
            var cities = await _context.Cities.ToListAsync();
            return Ok(cities);
        }

        [HttpGet("get-sample-cities")]
        public async Task<ActionResult> GetSample()
        {
            var cities = await _context.Cities.Where(c => c.Distance < 500 && c.Population > 500000).ToListAsync();
            return Ok(cities);
        }

        [HttpGet("get-min-max-distance")]
        public async Task<ActionResult> GetMinMax()
        {
            var max = await _context.Cities.OrderByDescending(c => c.Distance).FirstOrDefaultAsync();
            var min = await _context.Cities.OrderBy(c => c.Distance).FirstOrDefaultAsync();
            return Ok(new { max, min });
        }

        [HttpGet("get-cities-selectlist")]
        public async Task<ActionResult> GetCitiesSelectList()
        {
            var cities = await _context.Cities.Select(c => new { id = c.Id, value = c.Name }).ToListAsync();
            return Ok(cities);
        }
    }
}
