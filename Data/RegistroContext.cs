using PeruFails.Models;
using Microsoft.EntityFrameworkCore;

<<<<<<< HEAD
namespace busco.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registrarse> Registros { get; set; }
=======
namespace PeruFails.Data
{
    public class RegistroContext : DbContext
    {
<<<<<<< HEAD
        public DbSet<Registrarse> Registros { get; set; }
=======
        public DbSet<Registro> Registros { get; set; }
>>>>>>> f12087a0f3670cbf19801c6122bf2c33b8b9fe8b
>>>>>>> 453de3f8cc69fce380547657d974e5cff0fd17f3

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
}