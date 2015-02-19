<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="amigo.solicitar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <script type="text/javascript"
      src="http://maps.googleapis.com/maps/api/js?key=AIzaSyDVuND2HGk8qudUg74rqyRyOLEzFu-GrG8&sensor=falsee&region=EC">
    </script>
     <script type="text/javascript"
     src="../Scripts/localizacion.js">

    </script>
   

    <style type="text/css">
        .style1
        {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="map-canvas"></div>
    <p>Distancia total:
   
        <asp:TextBox ID="total" runat="server" Width="60px" Enabled="False" ></asp:TextBox>
        <asp:HiddenField ID="totalh" runat="server" Value="" />


        <asp:Label ID="Label1" runat="server" Text=" Km"></asp:Label>
         <table style="width:98%;">
        <tr>
            <td>

                <asp:Label ID="Label8" runat="server" Text="Tipo de unidad"></asp:Label>

            </td>
            <td>
                <asp:DropDownList ID="ddltipo" runat="server" 
                    onselectedindexchanged="ddlsectororigen_SelectedIndexChanged" 
                    Height="25px" Width="80px">
                </asp:DropDownList>
            </td>
            <td>
                </td>
        </tr>
        <tr>
            <td class="style1">

                <asp:Label ID="Label10" runat="server" Text="Servicio"></asp:Label>

            </td>
            <td class="style1">
                <asp:DropDownList ID="ddlservicio" runat="server" 
                    onselectedindexchanged="ddlsectororigen_SelectedIndexChanged" 
                    style="height: 22px">
                </asp:DropDownList>
            </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label9" runat="server" Text="Desea una carrera programada"></asp:Label>

            </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="S">Si</asp:ListItem>
                    <asp:ListItem Selected="True" Value="N">No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lblfecha" runat="server" Text="Fecha" Visible="False"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </td>
            <td>
                <asp:TextBox ID="txtfecha" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="lblhora" runat="server" Text="Hora" Visible="False"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </td>
            <td>
                <asp:TextBox ID="txthora" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td><asp:Label ID="lbl_lugarorigen" runat="server" Font-Bold="True" 
                    Font-Size="X-Large" Text="Origen"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Sector"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsectororigen" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlsectororigen_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Ciudadela"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlciudadelaorigen" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlciudadelaorigen_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdireccionorigen" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td><asp:Label ID="lbl_lugarorigen0" runat="server" Font-Bold="True" 
                    Font-Size="X-Large" Text="Destino"></asp:Label></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Sector"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlsectordestino" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlsectordestino_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Ciudadela"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlciudadeladestino" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlciudadeladestino_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdirecciondestino" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblError" runat="server" 
                    Text="Disculpe no hay unidades disponibles por el momento, intente mas tarde o solicite por télefono" 
                    Visible="False"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsolictar" runat="server" Text="Solicitar Unidad" 
                    onclick="btnsolictar_Click" />
&nbsp;&nbsp; &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </p>
</asp:Content>
