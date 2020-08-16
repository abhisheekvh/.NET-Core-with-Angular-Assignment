using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEB_API.models;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reasondetailController : ControllerBase
    {
        private readonly reasondetailcnt _context;

        public reasondetailController(reasondetailcnt context)
        {
            _context = context;
        }

        // GET: api/reasondetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<reasondetail>>> Getreasondetails()
        {
            return await _context.reasondetails.ToListAsync();
        }

        // GET: api/reasondetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<reasondetail>> Getreasondetail(int id)
        {
            var reasondetail = await _context.reasondetails.FindAsync(id);

            if (reasondetail == null)
            {
                return NotFound();
            }

            return reasondetail;
        }

        // PUT: api/reasondetail/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putreasondetail(int id, reasondetail reasondetail)
        {
            if (id != reasondetail.id1)
            {
                return BadRequest();
            }

            _context.Entry(reasondetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!reasondetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); 
        }

        // POST: api/reasondetail  
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<reasondetail>> Postreasondetail(reasondetail reasondetail)
        {
            _context.reasondetails.Add(reasondetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getreasondetail", new { id = reasondetail.id1 }, reasondetail);
        }

        // DELETE: api/reasondetail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<reasondetail>> Deletereasondetail(int id)
        {
            var reasondetail = await _context.reasondetails.FindAsync(id);
            if (reasondetail == null)
            {
                return NotFound();
            }

            _context.reasondetails.Remove(reasondetail);
            await _context.SaveChangesAsync();

            return reasondetail;
        }

        private bool reasondetailExists(int id)
        {
            return _context.reasondetails.Any(e => e.id1 == id);
        }
    }
}
