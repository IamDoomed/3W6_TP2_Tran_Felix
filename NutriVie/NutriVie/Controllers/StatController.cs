using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NutriVie.Models;
using NutriVie.Models.Data;

namespace NutriVie.Controllers
{
    public class StatController : Controller
    {
        private NutriVieDbContext _baseDonnees { get; set; }
        public StatController(NutriVieDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        // GET: StatController
        public async Task<ActionResult>  Index()
        {
            var recettesCourtes = await _baseDonnees.Recettes
            .Select(r => new {
                Nom = r.Nom,
                TempsTotal = r.TempsPreparation + r.TempsCuisson
            })
            .OrderBy(r => r.TempsTotal)
            .Take(4)
            .ToListAsync();

            // Vous pouvez stocker cela dans ViewBag pour l'envoyer à la vue sans DTO :
            ViewBag.RecettesCourtes = recettesCourtes;

            return View();
        }

        
    }
}
