using PeruFails.Models;
using Microsoft.EntityFrameworkCore;

namespace PeruFails.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Subir> Subirs { get; set; }

        public RegistroContext(DbContextOptions dco) : base(dco) {

        }
    }
}