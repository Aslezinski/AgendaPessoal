using Agenda.Models;
using System.Data.Entity;

namespace Agenda.DAO
{
    public class Context : DbContext
    {
        public DbSet<Contato> Contato { get; set; }
        public DbSet<TipoDeContato> TipoDeContato { get; set; }
    }
}