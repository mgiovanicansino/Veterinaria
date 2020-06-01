using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Veterinaria.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nombre")]
       
        [MaxLength(50)]
        public string Name { get; set; }
        [Display(Name = "Apellido")]
       
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Direccion")]
        
        [MaxLength(400)]
        public string Address { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MyConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
       
        DbSet<Veterinarian> Veterinarians { get; set; }
        DbSet<Consult> Consults  { get; set; }
        DbSet<History> Histories { get; set; }

        public System.Data.Entity.DbSet<Veterinaria.Models.Owner> Owners { get; set; }

        public System.Data.Entity.DbSet<Veterinaria.Models.Pet> Pets { get; set; }
    }
}