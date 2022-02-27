<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReniec.aspx.cs" Inherits="ClienteWeb.frmReniec" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h4>Buscador por DNI</h4>
    <br />
    <p>dni: <asp:TextBox runat="server" ID="txtDni" /></p>
   
    <p>
        <asp:Button Text="Buscar" runat="server" ID="btnBuscar" OnClick="btnBuscar_Click" /></p>
    <p>
        <asp:GridView runat="server" ID="gvDatos"></asp:GridView>
    </p>
</asp:Content>
