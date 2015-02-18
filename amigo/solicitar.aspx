<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="solicitar.aspx.cs" Inherits="amigo.solicitar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

<script type="text/javascript"
      src="http://maps.googleapis.com/maps/api/js?key=AIzaSyDVuND2HGk8qudUg74rqyRyOLEzFu-GrG8&sensor=falsee&region=EC">
    </script>
     <script type="text/javascript"
     src="Scripts/localizacion.js">

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="map-canvas"></div>
    <p>Total Distance: <asp:Label ID="total" runat="server" Text="0"></asp:Label> 
        <asp:Label ID="Label1" runat="server" Text=" Km"></asp:Label>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
         <table style="width:98%;">
        <tr>
            <td class="style1">

                <asp:Label ID="Label8" runat="server" Text="Tipo de unidad"></asp:Label>

            </td>
            <td class="style6">
                <asp:DropDownList ID="ddltipo" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlsectororigen_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style6">
                </td>
        </tr>
        <tr>
            <td class="style1">

                <asp:Label ID="Label9" runat="server" Text="Desea una carrera programada"></asp:Label>

            </td>
            <td class="style4">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="S">Si</asp:ListItem>
                    <asp:ListItem Selected="True" Value="N">No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">

                <asp:Label ID="lblfecha" runat="server" Text="Fecha" Visible="False"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </td>
            <td class="style4">
                <asp:TextBox ID="txtfecha" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">

                <asp:Label ID="lblhora" runat="server" Text="Hora" Visible="False"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </td>
            <td class="style4">
                <asp:TextBox ID="txthora" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <center><asp:Label ID="lbl_lugarorigen" runat="server" Font-Bold="True" 
                    Font-Size="X-Large" Text="Origen"></asp:Label></center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label2" runat="server" Text="Sector"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="ddlsectororigen" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlsectororigen_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style3">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label3" runat="server" Text="Ciudadela"></asp:Label>
            </td>
            <td class="style5">
                <asp:DropDownList ID="ddlciudadelaorigen" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlciudadelaorigen_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style5">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtdireccionorigen" runat="server"></asp:TextBox>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style5">
                <center><asp:Label ID="lbl_lugarorigen0" runat="server" Font-Bold="True" 
                    Font-Size="X-Large" Text="Destino"></asp:Label></center></td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label5" runat="server" Text="Sector"></asp:Label>
            </td>
            <td class="style5">
                <asp:DropDownList ID="ddlsectordestino" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlsectordestino_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label6" runat="server" Text="Ciudadela"></asp:Label>
            </td>
            <td class="style5">
                <asp:DropDownList ID="ddlciudadeladestino" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlciudadeladestino_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label7" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdirecciondestino" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsolictar" runat="server" Text="Solicitar Unidad" />
&nbsp;&nbsp; &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
    </table>
    </p>
</asp:Content>
