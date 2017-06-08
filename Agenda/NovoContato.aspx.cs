using Agenda.Controller;
using Agenda.Models;
using System;

namespace Agenda
{
    public partial class NovoContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DdlTipoDeContato.DataSource = null;
            DdlTipoDeContato.DataSource = TipoDeContatoController.ListarTipoDeContato();
            DdlTipoDeContato.DataBind();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            ContatoController.CadastrarContato(new Contato
            {
                Nome = TxtNome.Text,
                Email = TxtEmail.Text,
                Apelido = TxtApelido.Text,
                Celular = TxtCelular.Text,
                Telefone = TxtTelefone.Text,
                TipoDeContato = TipoDeContatoController.BuscarPorString(DdlTipoDeContato.SelectedItem.Text)
            });
            Response.Redirect("~/Contatos");
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contatos");
        }
    }
}