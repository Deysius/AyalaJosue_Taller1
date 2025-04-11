using AyalaJosue_Taller1.Models;
using AyalaJosue_Taller1.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace AyalaJosue_Taller1.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult View()
        {
            return View();
        }
        public ActionResult List()
        {
        
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var equipo = _repository.DevuelveEquiposPorID(id);
            return View(equipo);
        }
        [HttpPost]
        public ActionResult Edit(int Id, Equipo equipo)
        {
            //Proceso de guardar
            try
            {
                _repository.ActializarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
