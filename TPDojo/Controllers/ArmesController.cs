using BO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
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

        static DojoAPIConnection apiConnection = new DojoAPIConnection();

        // GET: ArmesController
        public async Task<ActionResult> Index()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync("api/Armes");

                if(!response.IsSuccessStatusCode)
                {
                    return NotFound();
                } else
                {
                    //Task? receivedTask = await response.Content.ReadFromJsonAsync<Task>();
                    
                    IEnumerable<Arme>? armes;
                         armes = await response.Content.ReadFromJsonAsync<IList<Arme>>();
                    return View(armes);
                }
            }
        }

        // GET: ArmesController/Details/5
        public async Task<ActionResult> DetailsAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync($"api/Armes/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound();
                }
                else
                {
                    Arme? arme;
                    arme = await response.Content.ReadFromJsonAsync<Arme>();
                    return View(arme);
                }
            }
            
        }

        // GET: ArmesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArmesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Arme arme)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
              

                var response = await httpClient.PostAsJsonAsync("api/Armes", arme);

                if (!response.IsSuccessStatusCode)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            //try
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return RedirectToAction(nameof(IndexAsync));
            //    }
            //    else
            //    {
            //        context.Armes.Add(new Arme
            //        {
            //            Nom = arme.Nom,
            //            Degats = arme.Degats,
            //        });
            //        context.SaveChanges();
            //        return RedirectToAction(nameof(IndexAsync));
            //    }

            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: ArmesController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            Arme? arme = await GetArmeAsync(id);
            if (arme is null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: ArmesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Arme arme)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = await httpClient.PutAsJsonAsync($"api/Armes/{id}", arme);

                if (!response.IsSuccessStatusCode)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            //try
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return RedirectToAction(nameof(Index));
            //    }
            //    else
            //    {
            //        Arme? armeToEdit = GetArme(id, context);
            //        armeToEdit!.Nom = arme.Nom;
            //        armeToEdit.Degats = arme.Degats;
            //        context.SaveChanges();
            //        return RedirectToAction(nameof(Index));
            //    }

            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: ArmesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            Arme? arme = await GetArmeAsync(id);
            if (arme is null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: ArmesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = await httpClient.DeleteAsync($"api/Armes/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            //Arme? arme = GetArme(id, context);
            //if (arme is null)
            //{
            //    return NotFound();
            //}
            //try
            //{

            //    if (context.IsWeaponAssignedToSamurai(arme.Id))
            //    {
            //        Samourai? samourai = context.Samourais.Where(s => s.Arme.Id == arme.Id).SingleOrDefault();
            //        Samourai porteur = samourai;
            //        throw new Exception($"Cette arme est assignée à un samouraï : {porteur.Nom}. Impossible de la supprimer.");
            //    }
            //    context.Armes.Remove(arme);
            //    context.SaveChanges();
            //    return RedirectToAction(nameof(Index));
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("", ex.Message);
            //    return View(arme);
            //}
        }

        public static async Task<Arme?> GetArmeAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiConnection.BASE_ADRESS);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync($"api/Armes/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                else
                {
                    Arme? arme;
                    arme = await response.Content.ReadFromJsonAsync<Arme>();
                    return arme;
                }
            }
        }
    }
}
