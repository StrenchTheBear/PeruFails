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
        public DbSet<Registro> Registros { get; set; }
>>>>>>> f12087a0f3670cbf19801c6122bf2c33b8b9fe8b

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
}