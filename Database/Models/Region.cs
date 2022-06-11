using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Region
    {
        public int IdRegion { get; set; }
        public string NameRegion { get; set; }

        //Navigation Property
        public ICollection<Pokemon> Pokemons { get; set; }
    }
}
