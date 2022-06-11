using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Tipo
    {
        public int IdType { get; set; }
        public string NameType { get; set; }

        //Navigation Properties
        public ICollection<Pokemon> PrimaryTypes { get; set; }
        public ICollection<Pokemon> SecondaryTypes { get; set; }
    }
}
