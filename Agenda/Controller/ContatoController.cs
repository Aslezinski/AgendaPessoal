using Agenda.DAO;
using Agenda.Models;
using System;
using System.Collections.Generic;

namespace Agenda.Controller
{
    class ContatoController
    {
        public static bool CadastrarContato(Contato contato)
        {
            try
            {
                ContatoDAO.CadastrarContato(contato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool EditarContato(Contato contatoEditado)
        {
            try
            {
                ContatoDAO.EditarContato(contatoEditado);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool ExcluirContato(Contato contato)
        {
            try
            {
                ContatoDAO.ExcluirContato(contato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Contato> ListarContatos()
        {
            return ContatoDAO.ListarContatos();
        }
    }
}
