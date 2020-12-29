using PeruFails.Models;
using Microsoft.EntityFrameworkCore;

namespace PeruFails.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registrarse> Registros { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
}