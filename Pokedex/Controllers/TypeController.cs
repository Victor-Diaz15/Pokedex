using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class TypeController : Controller
    {
        private readonly TypeService _typeService;

        public TypeController(PokedexContext dbContext)
        {
            _typeService = new(dbContext);
        }
        public async Task<IActionResult> IndexType()
        {
            return View(await _typeService.GetAllTypes());
        }
        public IActionResult AddType()
        {
            return View("SaveType", new TypeViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> AddType(TypeViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveType", vm);
            }
            await _typeService.AddType(vm);
            return RedirectToRoute(new { controller = "Type", action = "IndexType" });
        }

        public async Task<IActionResult> UpdateType(int id)
        {
            return View("SaveType", await _typeService.GetByIdTypeViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateType(TypeViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveType", vm);
            }
            await _typeService.UpdateType(vm);
            return RedirectToRoute(new { controller = "Type", action = "IndexType" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteType", await _typeService.GetByIdTypeViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteType(TypeViewModel type)
        {
            await _typeService.DeleteType(type.IdType);
            return RedirectToRoute(new { controller = "Type", action = "IndexType" });
        }
    }
}
