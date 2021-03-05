using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegularExpressionsController : ControllerBase
    {
        private readonly RegularExpressionContext _context;

        public RegularExpressionsController(RegularExpressionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegularExpressionGroup>>> GetRegularExpressionGroups()
        {
            return await _context.RegularExpressionGroups.Include(x => x.RegularExpressions).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RegularExpressionGroup>> GetRegularExpressionGroup(long id)
        {
            var group = await _context.RegularExpressionGroups.FindAsync(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegularExpressionGroup(long id, RegularExpressionGroup regularExpressionGroup)
        {
            if (id != regularExpressionGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(regularExpressionGroup).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<RegularExpressionGroup>> PostRegularExpressionGroup(RegularExpressionGroup regularExpressionGroup)
        {
            _context.RegularExpressionGroups.Add(regularExpressionGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRegularExpressionGroup), new { id = regularExpressionGroup.Id }, regularExpressionGroup);
        }
    }
}
