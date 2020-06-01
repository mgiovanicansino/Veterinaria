using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Pet> Pets { get; set; }
        
    }
}