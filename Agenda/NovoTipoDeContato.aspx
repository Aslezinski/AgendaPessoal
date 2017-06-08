<%@ Page Title="Novo Tipo De Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoTipoDeContato.aspx.cs" Inherits="Agenda.NovoTipoDeContato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1>Novo Tipo De Contato</h1>

    <asp:Label ID="LblDescricao" runat="server" Text="Descrição"></asp:Label>
    <asp:TextBox  ID="TxtDescricao" runat="server"></asp:TextBox>
    <br />
    <asp:Button class="btn" ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
    <asp:Button class="btn" ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" />

</asp:Content>