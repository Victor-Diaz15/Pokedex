using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options): base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Tipo> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //FLUENT API

            #region "tables"
            modelBuilder.Entity<Pokemon>().ToTable("Pokemons");
            modelBuilder.Entity<Region>().ToTable("Regions");
            modelBuilder.Entity<Tipo>().ToTable("Types");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<Pokemon>().HasKey(pokemon => pokemon.Id);
            modelBuilder.Entity<Region>().HasKey(region => region.IdRegion);
            modelBuilder.Entity<Tipo>().HasKey(type => type.IdType);
            #endregion

            #region "Relationships"
            modelBuilder.Entity<Region>()
                .HasMany<Pokemon>(region => region.Pokemons)
                .WithOne(pokemon => pokemon.Region)
                .HasForeignKey(pokemon => pokemon.IdRegion)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Tipo>()
                .HasMany<Pokemon>(type => type.PrimaryTypes)
                .WithOne(pokemon => pokemon.PrimaryType)
                .HasForeignKey(pokemon => pokemon.IdPrimaryType)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Tipo>()
                .HasMany<Pokemon>(type => type.SecondaryTypes)
                .WithOne(pokemon => pokemon.SecondaryType)
                .HasForeignKey(pokemon => pokemon.IdSecondaryType)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region "Property Configuration"

            #region "Pokemon"

            modelBuilder.Entity<Pokemon>()
                .Property(pokemon => pokemon.Name)
                .IsRequired();

            modelBuilder.Entity<Pokemon>()
                .Property(pokemon => pokemon.ImageUrl)
                .IsRequired();

            modelBuilder.Entity<Pokemon>()
                .Property(pokemon => pokemon.IdRegion)
                .IsRequired();

            modelBuilder.Entity<Pokemon>()
                .Property(pokemon => pokemon.IdPrimaryType)
                .IsRequired();

            #endregion

            #region "Region"

            modelBuilder.Entity<Region>()
                .Property(region => region.NameRegion)
                .IsRequired();

            #endregion

            #region "Type"

            modelBuilder.Entity<Tipo>()
                .Property(type => type.NameType)
                .IsRequired();

            #endregion

            #endregion
        }
    }
}
