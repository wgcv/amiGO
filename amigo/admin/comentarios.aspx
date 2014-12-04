<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="amigo.admin.comentarios1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 361px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="218px" onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        Width="878px">
                        <Columns>
                            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="nombreUsuario" HeaderText="Nombre de Usuario" />
                            <asp:BoundField DataField="mensaje" HeaderText="Mensaje" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p style="height: 49px">
    </p>
</asp:Content>
