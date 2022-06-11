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
    public class TypeRepository
    {
        private readonly PokedexContext _dbContext;

        public TypeRepository(PokedexContext dbContext)
        {
            _dbContext = dbContext;
        }

        //METHODS

        //Method to get all Types
        public async Task<List<Tipo>> GetAllAsync()
        {
            return await _dbContext.Set<Tipo>().ToListAsync();
        }
        //Method to get a type by id
        public async Task<Tipo> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Tipo>()
                .FirstOrDefaultAsync(type => type.IdType == id);
        }

        //Method to add new type
        public async Task AddAsync(Tipo type)
        {
            await _dbContext.Types.AddAsync(type);
            await _dbContext.SaveChangesAsync();
        }
        //Method to update a type
        public async Task UpdateAsync(Tipo type)
        {
            _dbContext.Entry(type).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        //Method to delete a region
        public async Task DeleteAsync(Tipo type)
        {
            _dbContext.Set<Tipo>().Remove(type);
            await _dbContext.SaveChangesAsync();
        }
    }
}
