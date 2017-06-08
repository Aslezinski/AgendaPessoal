<%@ Page Title="Novo Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoContato.aspx.cs" Inherits="Agenda.NovoContato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Novo Contato</h1>
        
    <asp:Label ID="LblNome" runat="server" Text="Nome: "></asp:Label>
    <asp:TextBox class="input-group" ID="TxtNome" runat="server"></asp:TextBox>

    <asp:Label ID="LblEmail" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox class="input-group" ID="TxtEmail" runat="server"></asp:TextBox>

    <asp:Label ID="LblApelido" runat="server" Text="Apelido: "></asp:Label>
    <asp:TextBox class="input-group" ID="TxtApelido" runat="server"></asp:TextBox>

    <asp:Label ID="LblTelefone" runat="server" Text="Telefone: "></asp:Label>
    <asp:TextBox class="input-group" ID="TxtTelefone" runat="server"></asp:TextBox>

    <asp:Label ID="LblCelular" runat="server" Text="Celular: "></asp:Label>
    <asp:TextBox class="input-group" ID="TxtCelular" runat="server"></asp:TextBox>

    <asp:Label ID="LblTipoDeContato" runat="server" Text="Tipo de Contato"></asp:Label>
    <asp:DropDownList ID="DdlTipoDeContato" DataTextField="Descricao" DataValueField="IdTipoDeContato" runat="server"></asp:DropDownList>

    <br /><br />

    <asp:Button class="btn" ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
    <asp:Button class="btn" ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" />

</asp:Content>
