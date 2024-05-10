using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace iCantina
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
