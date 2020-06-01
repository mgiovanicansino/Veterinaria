using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Veterinaria.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Display(Name ="Nombre")]
        [Required]
        public string Name { get; set; }
        [Display(Name ="Tipo")]
        [Required]
        public string PetType { get; set; }
        [Display(Name ="Edad")]
        public int Age { get; set; }
        [Display(Name ="Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }
        [Display(Name ="Color")]
        [Required]
        public string Color { get; set; }
        [Display(Name ="Peso")]
        [Required]
        public decimal Weigth { get; set; }
        [Display(Name ="Altura")]
        [Required]
        public decimal Heigth { get; set; }
        public string Img { get; set; }
        public ICollection<Consult> Consults { get; set; }
    }
}