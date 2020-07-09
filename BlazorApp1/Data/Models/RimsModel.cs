using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.Models
{
    public class RimsModel
    {
        [Required(ErrorMessage = "Цвят е задължително")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Марка е задължително")]
        public string RimBrand { get; set; }

        [Required(ErrorMessage = "Модел е задължително")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Размер е задължително")]
        public int Size { get; set; }
    }
}
