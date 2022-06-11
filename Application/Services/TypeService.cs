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
    public class TypeService
    {
        private readonly TypeRepository _typeRepository;
        private readonly PokemonRepository _pokemonRepository;
        public TypeService(PokedexContext dbContext)
        {
            _typeRepository = new(dbContext);
            _pokemonRepository = new(dbContext);
        }

        //METHODS

        //Method to get all types
        public async Task<List<TypeViewModel>> GetAllTypes()
        {
            var typeList = await _typeRepository.GetAllAsync();

            return typeList.Select(type => new TypeViewModel
            {
                IdType = type.IdType,
                NameType = type.NameType
            }).ToList();
        }

        //Method to get a type by id
        public async Task<TypeViewModel> GetByIdTypeViewModel(int id)
        {
            var type = await _typeRepository.GetByIdAsync(id);

            TypeViewModel vm = new();
            vm.IdType = type.IdType;
            vm.NameType = type.NameType;

            return vm;
        }

        //Method to add new type
        public async Task AddType(TypeViewModel vm)
        {
            Tipo type = new();
            type.NameType = vm.NameType;

            await _typeRepository.AddAsync(type);
        }

        //Method to update a type
        public async Task UpdateType(TypeViewModel vm)
        {
            Tipo type = new();
            type.IdType = vm.IdType;
            type.NameType = vm.NameType;

            await _typeRepository.UpdateAsync(type);
        }

        //Method to delete a type
        public async Task DeleteType(int id)
        {
            //Eliminando el pokemon con el tipo secundario antes de borrar el tipo.
            List<Pokemon> pokemonList = await _pokemonRepository.GetAllAsync();
            foreach (Pokemon item in pokemonList)
            {
                if (item.IdSecondaryType == id)
                {
                    await _pokemonRepository.DeleteAsync(item);
                }
            }

            var type = await _typeRepository.GetByIdAsync(id);
            await _typeRepository.DeleteAsync(type);
        }
    }
}
