using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class RegionViewModel
    {
        public int IdRegion { get; set; }

        [Required(ErrorMessage ="Debe sumunistar una region")]
        public string NameRegion { get; set; }
    }
}
