using Agenda.DAL;
using Agenda.Models;
using System.Collections.Generic;
using System.Linq;

namespace Agenda.DAO
{
    public class ContatoDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static bool CadastrarContato(Contato contato)
        {
            Context.Contato.Add(contato);
            Context.SaveChanges();
            return true;
        }

        public static bool EditarContato(Contato contatoEditado)
        {
            Context.Entry(contatoEditado).State = System.Data.Entity.EntityState.Modified;
            Context.SaveChanges();
            return false;
        }

        public static bool ExcluirContato(Contato contato)
        {
            Context.Entry(contato).State = System.Data.Entity.EntityState.Deleted;
            Context.SaveChanges();
            return false;
        }

        public static List<Contato> ListarContatos()
        {
            return Context.Contato.ToList();
        }
    }
}