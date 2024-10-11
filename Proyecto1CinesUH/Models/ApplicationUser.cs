using Microsoft.AspNetCore.Identity;
namespace Proyecto1CinesUH.Models
{
    public class ApplicationUser : IdentityUser 
    {
        public string Nombre { get; set; } = "";

        public string Apellidos { get; set; } = "";

        public string CorreoElectronico { get; set; } = "";

        public DateTime CeatedAt { get; set; }
    }
}
