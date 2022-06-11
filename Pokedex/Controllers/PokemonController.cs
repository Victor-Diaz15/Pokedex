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
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;
        private readonly RegionService _regionService;
        private readonly TypeService _typeService;
        public PokemonController(PokedexContext dbContext)
        {
            _typeService = new(dbContext);
            _regionService = new(dbContext);
            _pokemonService = new(dbContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _pokemonService.GetAllPokemons());
        }
        public async Task<IActionResult> AddPokemon()
        {
            ViewBag.Regions = await _regionService.GetAllRegions();
            ViewBag.Types = await _typeService.GetAllTypes();
            return View("SavePokemon", new SavePokemonViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> AddPokemon(SavePokemonViewModel vm)
        {
            ViewBag.Regions = await _regionService.GetAllRegions();
            ViewBag.Types = await _typeService.GetAllTypes();
            if (!ModelState.IsValid)
            {
                return View("SavePokemon", vm);
            }
            await _pokemonService.AddPokemon(vm);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index"});
        }

        public async Task<IActionResult> UpdatePokemon(int id)
        {
            ViewBag.Regions = await _regionService.GetAllRegions();
            ViewBag.Types = await _typeService.GetAllTypes();
            return View("SavePokemon", await _pokemonService.GetByIdSavePokemonViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePokemon(SavePokemonViewModel vm)
        {
            ViewBag.Regions = await _regionService.GetAllRegions();
            ViewBag.Types = await _typeService.GetAllTypes();
            if (!ModelState.IsValid)
            {
                return View("SavePokemon", vm);
            }
            await _pokemonService.UpdatePokemon(vm);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View("DeletePokemon", await _pokemonService.GetByIdSavePokemonViewModel(id));
        }
        [HttpPost]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            await _pokemonService.DeletePokemon(id);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }
    }
}
