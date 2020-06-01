using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.Models
{
    public class Veterinarian
    {
        public int Id { get; set; }
     
        [Display(Name = "Descripcion")]
        [Required]
        [MaxLength(400)]
        public string Description { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Consult> Consults { get; set; }
    }
}