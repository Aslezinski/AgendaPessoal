using Agenda.Controller;
using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class NovoTipoDeContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            TipoDeContatoController.CadastrarTipoDeContato(new TipoDeContato
            {
                Descricao = TxtDescricao.Text
            });

            Response.Redirect("~/Contatos");
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contatos");
        }
    }
}