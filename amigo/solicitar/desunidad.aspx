<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="desunidad.aspx.cs" Inherits="amigo.solicitar.desunidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 13px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center><h1>Unidad asignada</h1></center>
    <table style="width:100%;">
        <tr>
            <td>
                Chofer:</td>
            <td>
                <asp:Label ID="lblChofer" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Telefono:</td>
            <td>
                <asp:Label ID="lblTelefono" runat="server" Text="lblTelefono"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Modelo-Marca</td>
            <td class="style1">
                <asp:Label ID="lblModelo" runat="server" Text="Label"></asp:Label>
                -<asp:Label ID="lblMarca" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td>
                Placas</td>
            <td>
                <asp:Label ID="lblPlacas" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" 
                    NavigateUrl="~/wgcv/ubicacion taxist/index.html" Target="_blank">Realizar Tracking del taxista</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
