using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Permisos.Models;
using Permisos.Services;

namespace Permisos.Controllers
{
  [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : Controller
    {
        private readonly PermissionServices _services;

        public PermisoController(PermissionServices Services)
        {
            _services = Services;
        }

        [HttpGet]
        [Route("Listado")]
        public ActionResult<IEnumerable<Permiso>> Index()
        {
            var permiso = _services.GetAll().Result;
            return Json(permiso);
        }

        [HttpGet]
        [Route("ListadoTipoPermisos")]
        public ActionResult<IEnumerable<TipoPermiso>> ListadoTipoPermisos()
        {

            var permiso = _services.GetAllTipoPermisos().Result;
            return Json(permiso);
        }

        [HttpPost]        
        [Route("Create_Permiso")]
        public async Task<IActionResult> Create(Permiso Permiso)
        {

            if (ModelState.IsValid)
            {
                Permiso result = await _services.Create(Permiso);
                if (result != null)
                {
                    return View(result);

                }

            }
            return RedirectToAction(nameof(Create));

        }

        [HttpGet]
        [Route("Delete_Permiso")]
        public async Task<IActionResult> Delete([System.Web.Http.FromUri]int id)
        {
            id = 1;
            Permiso result = await _services.GetById(id);
            if (result != null)
            {
                Permiso deleted = await _services.Delete(result);

                if (deleted != null)
                {
                    return RedirectToAction(nameof(Index), new { Message = "Permiso Eliminado exitosamente" });
                }
            }

            return RedirectToAction(nameof(Index));

        }





    }
}