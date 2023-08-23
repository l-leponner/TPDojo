using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojoAPI.Utils;

namespace TPDojoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmesController : ControllerBase
    {
        //private readonly DojoAPIContext dojoContext;

        //public ArmesController(DojoAPIContext context)
        //{
        //    dojoContext = context;
        //}

        // GET: api/Armes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Arme>>> GetArmes([FromServices] DojoAPIContext dojoContext)
        {
          if (dojoContext.Armes == null)
          {
              return NotFound();
          }
            return await dojoContext.Armes.ToListAsync();
        }

        // GET: api/Armes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Arme>> GetArme([FromServices] DojoAPIContext dojoContext, int id)
        {
          if (dojoContext.Armes == null)
          {
              return NotFound();
          }
            var arme = await dojoContext.Armes.FindAsync(id);

            if (arme == null)
            {
                return NotFound();
            }

            return arme;
        }

        // PUT: api/Armes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArme([FromServices] DojoAPIContext dojoContext, int id, Arme arme)
        {
            if (id != arme.Id)
            {
                return BadRequest();
            }

            dojoContext.Entry(arme).State = EntityState.Modified;

            try
            {
                await dojoContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmeExists(dojoContext, id))
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

        // POST: api/Armes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Arme>> PostArme([FromServices] DojoAPIContext dojoContext, Arme arme)
        {
          if (dojoContext.Armes == null)
          {
              return Problem("Entity set 'DojoAPIContext.Armes'  is null.");
          }
            dojoContext.Armes.Add(arme);
            await dojoContext.SaveChangesAsync();

            return CreatedAtAction("GetArme", new { id = arme.Id }, arme);
        }

        // DELETE: api/Armes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArme([FromServices] DojoAPIContext dojoContext, int id)
        {
            if (dojoContext.Armes == null)
            {
                return NotFound();
            }
            var arme = await dojoContext.Armes.FindAsync(id);
            if (arme == null)
            {
                return NotFound();
            }
            Samourai? samouraiToDisarm = await dojoContext.Samourais.Where(a => a.Id == arme.Id).SingleOrDefaultAsync();
            if(samouraiToDisarm != null)
            {
                samouraiToDisarm.Arme = null;
            }
            
            dojoContext.Armes.Remove(arme);
            await dojoContext.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmeExists([FromServices] DojoAPIContext dojoContext, int id)
        {
            return (dojoContext.Armes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
