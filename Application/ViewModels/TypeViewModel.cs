using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class TypeViewModel
    {
        public int IdType { get; set; }

        [Required(ErrorMessage = "Debe sumunistar un tipo")]
        public string NameType { get; set; }
    }
}
