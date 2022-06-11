using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class PokemonRepository
    {
        private readonly PokedexContext _dbContext;

        public PokemonRepository(PokedexContext dbContext)
        {
            _dbContext = dbContext;
        }

        //METHODS

        //Method to get all pokemons
        public async Task<List<Pokemon>> GetAllAsync()
        {
            return await _dbContext.Set<Pokemon>()
                .Include(pokemon => pokemon.Region)
                .Include(pokemon => pokemon.PrimaryType)
                .Include(pokemon => pokemon.SecondaryType)
                .ToListAsync();
        }
        //Method to get a pokemon by id
        public async Task<Pokemon> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Pokemon>()
                .Include(pokemon => pokemon.Region)
                .Include(pokemon => pokemon.PrimaryType)
                .Include(pokemon => pokemon.SecondaryType)
                .FirstOrDefaultAsync(pokemon => pokemon.Id == id);
        }

        //Method to add new Pokemon
        public async Task AddAsync(Pokemon pokemon)
        {
            await _dbContext.Pokemons.AddAsync(pokemon);
            await _dbContext.SaveChangesAsync();
        }
        //Method to update a Pokemon
        public async Task UpdateAsync(Pokemon pokemon)
        {
            _dbContext.Entry(pokemon).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        //Method to delete a Pokemon
        public async Task DeleteAsync(Pokemon pokemon)
        {
            _dbContext.Set<Pokemon>().Remove(pokemon);
            await _dbContext.SaveChangesAsync();
        }
    }
}
