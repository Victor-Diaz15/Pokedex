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
    public class RegionRepository
    {
        private readonly PokedexContext _dbContext;

        public RegionRepository(PokedexContext dbContext)
        {
            _dbContext = dbContext;
        }

        //METHODS

        //Method to get all Regions
        public async Task<List<Region>> GetAllAsync()
        {
            return await _dbContext.Set<Region>().ToListAsync();
        }
        //Method to get a region by id
        public async Task<Region> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Region>()
                .FirstOrDefaultAsync(region => region.IdRegion == id);
        }

        //Method to add new region
        public async Task AddAsync(Region region)
        {
            await _dbContext.Regions.AddAsync(region);
            await _dbContext.SaveChangesAsync();
        }
        //Method to update a region
        public async Task UpdateAsync(Region region)
        {
            _dbContext.Entry(region).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        //Method to delete a region
        public async Task DeleteAsync(Region region)
        {
            _dbContext.Set<Region>().Remove(region);
            await _dbContext.SaveChangesAsync();
        }
    }
}
