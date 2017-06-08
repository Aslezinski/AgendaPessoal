using Agenda.DAL;
using Agenda.Models;
using System;
using System.Collections.Generic;

namespace Agenda.Controller
{
    class TipoDeContatoController
    {
        public static bool CadastrarTipoDeContato(TipoDeContato tipoDeContato)
        {
            try
            {
                TipoDeContatoDAO.CadastrarTipoDeContato(tipoDeContato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<TipoDeContato> ListarTipoDeContato()
        {
            return TipoDeContatoDAO.ListarTipoDeContato();
        }

        public static TipoDeContato BuscarPorString(string text)
        {
            return TipoDeContatoDAO.Buscar(text);
        }
    }
}
