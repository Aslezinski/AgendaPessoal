using Agenda.DAO;
using Agenda.Models;
using System.Collections.Generic;
using System.Linq;

namespace Agenda.DAL
{
    public class TipoDeContatoDAO
    {
        private static Context Context = Singleton.Instance.Context;

        public static bool CadastrarTipoDeContato(TipoDeContato tipoDeContato)
        {
            Context.TipoDeContato.Add(tipoDeContato);
            Context.SaveChanges();
            return true;
        }

        public static bool EditarTipoDeContato(TipoDeContato tipoDeContato, TipoDeContato tipoDeContatoEditado)
        {
            Context.Entry(tipoDeContato).CurrentValues.SetValues(tipoDeContatoEditado);
            Context.SaveChanges();
            return false;
        }

        public static List<TipoDeContato> ListarTipoDeContato()
        {
            List<TipoDeContato> tipoDeContato = new List<TipoDeContato>();

            tipoDeContato = Context.TipoDeContato.ToList();

            return tipoDeContato;
        }

        public static TipoDeContato Buscar(string text)
        {
            return Context.TipoDeContato.FirstOrDefault(p => p.Descricao.Equals(text));
        }
    }
}