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
    public class RegionController : Controller
    {
        private readonly RegionService _regionService;

        public RegionController(PokedexContext dbContext)
        {
            _regionService = new(dbContext);
        }
        public async Task<IActionResult> IndexRegion()
        {
            return View(await _regionService.GetAllRegions());
        }
        public IActionResult AddRegion()
        {
            return View("SaveRegion", new RegionViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> AddRegion(RegionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveRegion", vm);
            }
            await _regionService.AddRegion(vm);
            return RedirectToRoute(new { controller = "Region", action = "IndexRegion" });
        }

        public async Task<IActionResult> UpdateRegion(int id)
        {
            return View("SaveRegion", await _regionService.GetByIdRegionViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRegion(RegionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveRegion", vm);
            }
            await _regionService.UpdateRegion(vm);
            return RedirectToRoute(new { controller = "Region", action = "IndexRegion" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeleteRegion", await _regionService.GetByIdRegionViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRegion(RegionViewModel region)
        {
            await _regionService.DeleteRegion(region.IdRegion);
            return RedirectToRoute(new { controller = "Region", action = "IndexRegion" });
        }
    }          
}
