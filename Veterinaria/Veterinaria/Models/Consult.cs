using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public class Consult
    {
        public int Id { get; set; }
        [Display(Name ="Dia de Consulta")]
        [Required]
        public DateTime ConsultDay { get; set; }
        [Display(Name ="Descripcion")]
        [Required]
        public string Descripction { get; set; }
        [Display(Name ="Tipo de Consulta")]
        [Required]
        public string ConsultType { get; set; }
        public Veterinarian veterinarian { get; set; }
        public Pet pet { get; set; }
    }
}