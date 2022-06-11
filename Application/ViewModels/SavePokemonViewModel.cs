using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class SavePokemonViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe especificar un nombre de pokemon")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe especificar una imagen de pokemon")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Debe especificar la region del pokemon")]
        public int IdRegion { get; set; }

        [Required(ErrorMessage = "Debe especificar tipo primario del pokemon")]
        public int IdPrimaryType { get; set; }
        public int IdSecondaryType { get; set; }
    }
}
