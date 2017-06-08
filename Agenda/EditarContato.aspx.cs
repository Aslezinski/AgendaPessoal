using Agenda.Controller;
using Agenda.Models;
using System;
using System.Linq;
using Agenda.DAO; 

namespace Agenda
{
    public partial class EditarContato : System.Web.UI.Page
    {
        Contato contato;

        protected void Page_Load(object sender, EventArgs e)
        {
            DdlTipoDeContato.DataSource = TipoDeContatoController.ListarTipoDeContato();
            DdlTipoDeContato.DataBind();

            contato = ContatoController.ListarContatos().Single(p => p.IdContato == Convert.ToInt32(Request.QueryString["IdContato"]));

            if (TxtApelido.Text.Equals("")) 
            {
                TxtNome.Text = contato.Nome;
                TxtEmail.Text = contato.Email;
                TxtApelido.Text = contato.Apelido;
                TxtCelular.Text = contato.Celular;
                TxtTelefone.Text = contato.Telefone;
                DdlTipoDeContato.SelectedValue = contato.TipoDeContato.IdTipoDeContato.ToString();
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            contato.Nome = TxtNome.Text;
            contato.Email = TxtEmail.Text;
            contato.Apelido = TxtApelido.Text;
            contato.Celular = TxtCelular.Text;
            contato.Telefone = TxtTelefone.Text;
            contato.TipoDeContato = TipoDeContatoController.BuscarPorString(DdlTipoDeContato.SelectedItem.Text);

            ContatoController.EditarContato(contato);

            Response.Redirect("~/Contatos");
        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            contato.Nome = TxtNome.Text;
            contato.Email = TxtEmail.Text;
            contato.Apelido = TxtApelido.Text;
            contato.Celular = TxtCelular.Text;
            contato.Telefone = TxtTelefone.Text;
            contato.TipoDeContato = TipoDeContatoController.BuscarPorString(DdlTipoDeContato.SelectedItem.Text);

            ContatoController.ExcluirContato(contato);
            Response.Redirect("~/NovoContato");
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contatos");
        }
    }
}