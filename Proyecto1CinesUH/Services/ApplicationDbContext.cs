using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto1CinesUH.Models;
namespace Proyecto1CinesUH.Services


{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var cliente = new IdentityRole("cliente");
            cliente.NormalizedName = "cliente";

            var boletero = new IdentityRole("boletero");
            boletero.NormalizedName = "boletero";

            builder.Entity<IdentityRole>().HasData(admin, cliente, boletero);
        }
    }
}
