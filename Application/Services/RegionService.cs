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
    public class RegionService
    {
        private readonly RegionRepository _regionRepository;

        public RegionService(PokedexContext dbContext)
        {
            _regionRepository = new(dbContext);
        }

        //METHODS

        //Method to get all regions
        public async Task<List<RegionViewModel>> GetAllRegions()
        {
            var regionList = await _regionRepository.GetAllAsync();

            return regionList.Select(region => new RegionViewModel
            {
                IdRegion = region.IdRegion,
                NameRegion = region.NameRegion
            }).ToList();
        }

        //Method to get a region by id
        public async Task<RegionViewModel> GetByIdRegionViewModel(int id)
        {
            var region = await _regionRepository.GetByIdAsync(id);

            RegionViewModel vm = new();
            vm.IdRegion = region.IdRegion;
            vm.NameRegion = region.NameRegion;

            return vm;
        }

        //Method to add new region
        public async Task AddRegion(RegionViewModel vm)
        {
            Region region = new();
            region.NameRegion = vm.NameRegion;
            
            await _regionRepository.AddAsync(region);
        }

        //Method to update a region
        public async Task UpdateRegion(RegionViewModel vm)
        {
            Region region = new();
            region.IdRegion = vm.IdRegion;
            region.NameRegion = vm.NameRegion;
           
            await _regionRepository.UpdateAsync(region);
        }

        //Method to delete a region
        public async Task DeleteRegion(int id)
        {
            var region = await _regionRepository.GetByIdAsync(id);
            await _regionRepository.DeleteAsync(region);
        }
    }
}
