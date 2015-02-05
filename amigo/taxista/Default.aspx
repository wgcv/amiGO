<%@ Page Title="" Language="C#" MasterPageFile="~/taxista/serviciotaxi.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="amigo.taxista.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 18px;
        }
        .style2
        {
            height: 103px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:98%;">
        <tr>
            <td class="style2">
                </td>
            <td class="style2">
                <h1>Servicio Para el taxista</h1><br /></td>
            <td class="style2">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nombre del pasajero: " 
                    Visible="False"></asp:Label>
                <asp:Label ID="lblInformacion" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            
            <td>
                <asp:Label ID="Label4" runat="server" Text="Celular: " Visible="False"></asp:Label>
                <asp:Label ID="lblCelular" runat="server" EnableTheming="True" Text="label" 
                    Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>

        </tr>
        <tr>
            <td class="style1">
                </td>
            
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="    Dirección: " Visible="False"></asp:Label>
            
                <asp:Label ID="lblDireccion" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="style1">
                </td>
           
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            
        
            <td>
                <asp:Label ID="Label3" runat="server" Text="Valor de la Carrera: " 
                    Visible="False"></asp:Label>
                <asp:Label ID="lblValor" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            
            <td>
               <center> 
                    <asp:Button ID="btnPasajero" runat="server" Text="Con el pasajero" 
                        Width="200px" onclick="btnPasajero_Click" Visible="False" /> 
                    <asp:Button ID="btnDisponible" runat="server" Text="Unidad Disponible" 
                       Width="200px" onclick="btnDisponible_Click" /> 
                    <asp:Button ID="btnSalir" runat="server" Text="Salir del Servicio" 
                       Width="200px" onclick="btnSalir_Click" Visible="False" /></center>
            </td>
            <td>
                &nbsp;</td>
          
        </tr>
    </table>
</asp:Content>
