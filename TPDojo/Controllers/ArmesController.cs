using BO;
using Microsoft.AspNetCore.Mvc;
using TPDojo.Utils;

namespace TPDojo.Controllers
{
    public class ArmesController : Controller
    {
        //private readonly DojoContext dojoContext;

        //public ArmesController(DojoContext context)
        //{
        //    dojoContext = context;
        //}



        // GET: ArmesController
        public ActionResult Index([FromServices] DojoContext dojoContext)
        {
            List<Arme> armes = dojoContext.Armes.ToList();

            return View(armes);
        }

        // GET: ArmesController/Details/5
        public ActionResult Details([FromServices] DojoContext context, int id)
        {
            Arme? arme = GetArme(id, context);
            if (arme is null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // GET: ArmesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArmesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromServices] DojoContext context, Arme arme)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    context.Armes.Add(new Arme
                    {
                        Nom = arme.Nom,
                        Degats = arme.Degats,
                    });
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: ArmesController/Edit/5
        public ActionResult Edit([FromServices] DojoContext context, int id)
        {
            Arme? arme = GetArme(id, context);
            if (arme is null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: ArmesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromServices] DojoContext context, int id, Arme arme)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    Arme? armeToEdit = GetArme(id, context);
                    armeToEdit!.Nom = arme.Nom;
                    armeToEdit.Degats = arme.Degats;
                    context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: ArmesController/Delete/5
        public ActionResult Delete([FromServices] DojoContext context, int id)
        {
            Arme? arme = GetArme(id, context);
            if (arme is null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: ArmesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, [FromServices] DojoContext context)
        {
            Arme? arme = GetArme(id, context);
            if (arme is null)
            {
                return NotFound();
            }
            try
            {
                
                if (context.IsWeaponAssignedToSamurai(arme.Id))
                {
                    throw new Exception("Cette arme est assignée à un samouraï. Impossible de la supprimer.");
                }
                context.Armes.Remove(arme);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(arme);
            }
        }

        public static Arme? GetArme(int id, [FromServices] DojoContext context)
        {
            Arme? arme = context.Armes.Find(id);
            return arme;
        }
    }
}
