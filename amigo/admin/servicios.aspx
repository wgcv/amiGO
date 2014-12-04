<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="servicios.aspx.cs" Inherits="amigo.admin.servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 95px;
        }
        .style2
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p style="height: 35px">
        <asp:Label ID="lblbuscar" runat="server" Text="Buscar por: "></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="ddlbucar" runat="server">
            <asp:ListItem Value="codigo">Codigo</asp:ListItem>
            <asp:ListItem Value="servicio">Servicio</asp:ListItem>
            <asp:ListItem Value="estado">Estado</asp:ListItem>
            <asp:ListItem Value="valor">Valor</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:TextBox ID="txtbuscar" runat="server" Width="157px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
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
                            <asp:ButtonField CommandName="modificar" Text="Modificar" />
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="servicio" HeaderText="Servicio" />
                            <asp:BoundField DataField="valor" HeaderText="Valor" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <table style="width:100%;">
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnrefrescar" runat="server" Text="Refrescar" Width="85px" />
                    &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                    <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtcodigo" runat="server" Width="89px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style2">
                    <asp:Label ID="lblservicio" runat="server" Text="Servicio"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtservicio" runat="server" Width="89px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvservicio" runat="server" 
                        ControlToValidate="txtservicio" ErrorMessage="Ingrese el servicio" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style2">
                    <asp:Label ID="lblvalor" runat="server" Text="Valor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtvalor" runat="server" Width="89px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvservicio0" runat="server" 
                        ControlToValidate="txtvalor" ErrorMessage="Ingrese el valor del servicio" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style2">
                    <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtestado" runat="server" Width="52px" MaxLength="1">A</asp:TextBox>
                &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:ValidationSummary 
                    ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblmensaje" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnlimpiar" runat="server" Text="Limpiar" Width="85px" />
                &nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>
