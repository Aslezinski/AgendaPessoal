using Agenda.Controller;
using System;
using System.Web.UI.WebControls;

namespace Agenda
{
    public partial class Contatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GrdContatos.DataSource = ContatoController.ListarContatos();
            GrdContatos.DataBind();
        }

        protected void BtnNovoContato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NovoContato");
        }

        protected void GrdContatos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect($"~/EditarContato?IdContato={ GrdContatos.DataKeys[e.NewEditIndex].Value }");
        }
    }
}