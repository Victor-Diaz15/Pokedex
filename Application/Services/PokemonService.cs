using Application.Repositories;
using Application.ViewModels;
using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PokemonService
    {
        private readonly PokemonRepository _pokemonRepository;

        public PokemonService(PokedexContext dbContext)
        {
            _pokemonRepository = new(dbContext);
        }

        //METHODS

        //Method to get all pokemons
        public async Task<List<PokemonViewModel>> GetAllPokemons()
        {
            var pokemonList = await _pokemonRepository.GetAllAsync();

            return pokemonList.Select(pokemon => new PokemonViewModel
            {
                Id = pokemon.Id,
                Name = pokemon.Name,
                ImageUrl = pokemon.ImageUrl,
                Region = pokemon.Region.NameRegion,
                PrimaryType = pokemon.PrimaryType.NameType,
                SecondaryType = pokemon.SecondaryType.NameType

            }).ToList();
        }

        //Method to get all pokemons with filters
        public async Task<List<PokemonViewModel>> GetAllPokemonsWithFilters(FiltersViewModel filters)
        {
            var pokemonList = await _pokemonRepository.GetAllAsync();

            var listViewModel = pokemonList.Select(pokemon => new PokemonViewModel
            {
                Id = pokemon.Id,
                Name = pokemon.Name,
                ImageUrl = pokemon.ImageUrl,
                Region = pokemon.Region.NameRegion,
                PrimaryType = pokemon.PrimaryType.NameType,
                SecondaryType = pokemon.SecondaryType.NameType,
                IdRegion = pokemon.IdRegion
            }).ToList();

            if (!string.IsNullOrWhiteSpace(filters.Name))
            {
                listViewModel = listViewModel.Where(pokemon => pokemon.Name == filters.Name).ToList();
                return listViewModel;
            }
            if (filters.IdRegion != null)
            {
                listViewModel = listViewModel.Where(pokemon => pokemon.IdRegion == filters.IdRegion.Value).ToList();
            }

            return listViewModel;
        }

        //Method to get a pokemon by id
        public async Task<SavePokemonViewModel> GetByIdSavePokemonViewModel(int id)
        {
            var pokemon = await _pokemonRepository.GetByIdAsync(id);

            SavePokemonViewModel vm = new();
            vm.Id = pokemon.Id;
            vm.Name = pokemon.Name;
            vm.ImageUrl = pokemon.ImageUrl;
            vm.IdRegion = pokemon.IdRegion;
            vm.IdPrimaryType = pokemon.IdPrimaryType;
            vm.IdSecondaryType = pokemon.IdSecondaryType;

            return vm;
        }

        //Method to add new Pkemon
        public async Task AddPokemon(SavePokemonViewModel vm)
        {
            Pokemon pokemon = new();
            pokemon.Name = vm.Name;
            pokemon.ImageUrl = vm.ImageUrl;
            pokemon.IdRegion = vm.IdRegion;
            pokemon.IdPrimaryType = vm.IdPrimaryType;
            pokemon.IdSecondaryType = vm.IdSecondaryType;

            await _pokemonRepository.AddAsync(pokemon);
        }

        //Method to update a Pokemon
        public async Task UpdatePokemon(SavePokemonViewModel vm)
        {
            Pokemon pokemon = new();
            pokemon.Id = vm.Id;
            pokemon.Name = vm.Name;
            pokemon.ImageUrl = vm.ImageUrl;
            pokemon.IdRegion = vm.IdRegion;
            pokemon.IdPrimaryType = vm.IdPrimaryType;
            pokemon.IdSecondaryType = vm.IdSecondaryType;

            await _pokemonRepository.UpdateAsync(pokemon);
        }

        //Method to delete a pokemon
        public async Task DeletePokemon(int id)
        {
            var pokemon = await _pokemonRepository.GetByIdAsync(id);
            await _pokemonRepository.DeleteAsync(pokemon);
        }
    }
}
