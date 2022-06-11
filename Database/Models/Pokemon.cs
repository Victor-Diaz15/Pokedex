using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }


        //Navigation Property
        public int IdRegion { get; set; }
        public Region Region { get; set; }

        //Navigation Property
        public int IdPrimaryType { get; set; }
        public Tipo PrimaryType { get; set; }

        //Navigation Property
        public int IdSecondaryType { get; set; }
        public Tipo SecondaryType { get; set; }

        
    }
}
