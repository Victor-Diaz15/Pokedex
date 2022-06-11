using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class HomeController : Controller
    {
        private readonly PokemonService _pokemonService;
        private readonly RegionService _regionService;
        public HomeController(PokedexContext dbContext)
        {
            _regionService = new(dbContext);
            _pokemonService = new(dbContext);
        }

        public async Task<IActionResult> Index(FiltersViewModel vm)
        {
            ViewBag.Regions = await _regionService.GetAllRegions();
            return View(await _pokemonService.GetAllPokemonsWithFilters(vm));
        }
    }
}
