<%@ Page Title="Contatos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contatos.aspx.cs" Inherits="Agenda.Contatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView class="panel panel-default" ID="GrdContatos" runat="server" OnRowEditing="GrdContatos_RowEditing" DataKeyNames="IdContato">
        <Columns>
            <asp:CommandField HeaderText="Editar" ShowEditButton="True" ShowHeader="True"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <br />
<asp:Button ID="BtnNovoContato" runat="server" Text="Novo" OnClick="BtnNovoContato_Click" />
</asp:Content>