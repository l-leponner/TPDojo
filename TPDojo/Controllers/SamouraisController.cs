using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;
using TPDojo.Utils;
using TPDojo.Models;

namespace TPDojo.Controllers
{
    public class SamouraisController : Controller
    {
        //private readonly DojoContext dojoContext;

        //public SamouraisController(DojoContext context)
        //{
        //    dojoContext = context;
        //}

        // GET: Samourais
        public async Task<IActionResult> Index([FromServices] DojoContext dojoContext,
            string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            //List<Samourai> samourais = await dojoContext.Samourais.Include(a => a.Arme).ToListAsync();

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NomSortParm"] = String.IsNullOrEmpty(sortOrder) ? "nom_desc" : "";
            ViewData["ForceSortParm"] = sortOrder == "Force" ? "force_desc" : "Force";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;

            var samourais = dojoContext.Samourais.Include(s => s.Arme).Include(s => s.ArtsMartiaux).Select(s => s);
                //from s in dojoContext.Samourais
                //            join a in dojoContext.Armes on s.Arme.Id equals a.Id
                //            select s;

            
            if (!String.IsNullOrEmpty(searchString))
            {
                samourais = samourais.Where(s => s.Nom.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "nom_desc":
                    samourais = samourais.OrderByDescending(s => s.Nom);
                    break;
                case "Force":
                    samourais = samourais.OrderBy(s => s.Force);
                    break;
                case "force_desc":
                    samourais = samourais.OrderByDescending(s => s.Force);
                    break;
                default:
                    samourais = samourais.OrderBy(s => s.Nom);
                    break;
            }
            int pageSize = 12;
            return dojoContext.Samourais != null ?
                          View(await PaginatedList<Samourai>.CreateAsync(samourais, pageNumber ?? 1, pageSize)) :
                          base.Problem("Entity set 'DojoContext.Samourais'  is null.");
        }

        // GET: Samourais/Details/5
        public async Task<IActionResult> Details([FromServices] DojoContext dojoContext, int? id)
        {
            if (id == null || dojoContext.Samourais == null)
            {
                return NotFound();
            }

            var samourai = await dojoContext.Samourais.Include(s => s.Arme).Include(s => s.ArtsMartiaux).SingleAsync(s => s.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // GET: Samourais/Create
        public IActionResult Create([FromServices] DojoContext dojoContext)
        {
            //List<int> idsArmesEquipees = dojoContext.Samourais.Where(s => s.Arme.Val).Select(s => s.Arme.Id).ToList();
            //IQueryable<Arme> armesDisponibles = dojoContext.Armes.Where(!idsArmesEquipees.Contains())
            SamouraisVM samouraisVM = new SamouraisVM();
            samouraisVM.SelectArmes = new SelectList(dojoContext.Armes.ToList(), "Id", "Nom");
            samouraisVM.SelectArtsMartiaux = new MultiSelectList(dojoContext.ArtsMartiaux.ToList(), "Id", "Nom");
            return View(samouraisVM);
        }

        // POST: Samourais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromServices] DojoContext dojoContext, SamouraisVM samouraisVM)
        {
            if (!ModelState.IsValid && samouraisVM == null)
            {
                return View(samouraisVM);

            }
            else
            {

                Samourai samourai = new Samourai
                {
                    Nom = samouraisVM.Nom,
                    Force = samouraisVM.Force,
                    Arme = (samouraisVM.ArmeId == null) ? null : dojoContext.Armes.Find(samouraisVM.ArmeId),
                    ArtsMartiaux = (samouraisVM.ArtsMartiauxIds == null) ? null : dojoContext.ArtsMartiaux.Where(a => samouraisVM.ArtsMartiauxIds.Contains(a.Id)).ToList()
                };
                await dojoContext.Samourais.AddAsync(samourai);
                await dojoContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Samourais/Edit/5
        public async Task<IActionResult> Edit([FromServices] DojoContext dojoContext, int? id)
        {
            if (id == null || dojoContext.Samourais == null)
            {
                return NotFound();
            }

            var samourai = await dojoContext.Samourais.FindAsync(id);

            if (samourai == null)
            {
                return NotFound();
            }
            SamouraisVM samouraisVM = new SamouraisVM();
            samouraisVM.SelectArmes = new SelectList(dojoContext.Armes.ToList(), "Id", "Nom");
            samouraisVM.SelectArtsMartiaux = new MultiSelectList(dojoContext.ArtsMartiaux.ToList(), "Id", "Nom");
            samouraisVM.Id = samourai.Id;
            samouraisVM.Nom = samourai.Nom;
            samouraisVM.Force = samourai.Force;
            samouraisVM.ArmeId = (samourai.Arme == null) ? null : samourai.Arme.Id;
            samouraisVM.ArtsMartiauxIds = samourai.ArtsMartiaux!.Select(a => a.Id).ToList();

            return View(samouraisVM);
        }

        // POST: Samourais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromServices] DojoContext dojoContext, int id, SamouraisVM samouraisVM)
        {
            if (id != samouraisVM.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid && samouraisVM == null)
            {
                return View(samouraisVM);

            }
            else
            {
                try
                {
                    Samourai? samourai = dojoContext.Samourais.Find(id);
                    if (samourai is null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        samourai.Nom = samouraisVM.Nom;
                        samourai.Force = samouraisVM.Force;
                        samourai.Arme = (samouraisVM.ArmeId == null) ? null : dojoContext.Armes.Find(samouraisVM.ArmeId);
                        samourai.ArtsMartiaux = (samouraisVM.ArtsMartiauxIds == null) ? null : dojoContext.ArtsMartiaux.Where(a => samouraisVM.ArtsMartiauxIds.Contains(a.Id)).ToList();
                        dojoContext.Update(samourai);
                        await dojoContext.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SamouraiExists(dojoContext, samouraisVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

        }

        // GET: Samourais/Delete/5
        public async Task<IActionResult> Delete([FromServices] DojoContext dojoContext, int? id)
        {
            if (id == null || dojoContext.Samourais == null)
            {
                return NotFound();
            }

            var samourai = await dojoContext.Samourais.Include(s => s.Arme).Include(s => s.ArtsMartiaux).SingleAsync(s => s.Id == id);
            if (samourai == null)
            {
                return NotFound();
            }

            return View(samourai);
        }

        // POST: Samourais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([FromServices] DojoContext dojoContext, int id)
        {
            if (dojoContext.Samourais == null)
            {
                return Problem("Entity set 'DojoContext.Samourais'  is null.");
            }
            var samourai = await dojoContext.Samourais.FindAsync(id);
            if (samourai != null)
            {
                dojoContext.Samourais.Remove(samourai);
            }

            await dojoContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SamouraiExists([FromServices] DojoContext dojoContext, int id)
        {
            return (dojoContext.Samourais?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
