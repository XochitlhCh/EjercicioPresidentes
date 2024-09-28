using EjercicioPresidentes.Models;
using EjercicioPresidentes.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioPresidentes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PresidentesContext context = new PresidentesContext();
            var pres = context.Presidente.OrderBy(x=>x.InicioGobierno).Select(x => new PresidenteModel
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Periodo = $"{x.InicioGobierno.Year} - {x.TerminoGobierno!.Value.Year}"

            });

            IndexViewModel ivm = new IndexViewModel
            {
                Presidentes = pres,
            };
            return View(ivm);
        }


        public IActionResult biografia(int id)
        {

            return View();
        }
    }
}
