<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="unidad.aspx.cs" Inherits="amigo.admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            width: 812px;
        }
        .style3
        {
            width: 812px;
            height: 28px;
        }
        .style4
        {
            height: 28px;
        }
        .style5
        {
            width: 812px;
            height: 42px;
        }
        .style6
        {
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="lblbuscar" runat="server" Text="Buscar por: "></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="ddllist" runat="server">
            <asp:ListItem Value="codigo">Codigo</asp:ListItem>
            <asp:ListItem Value="modelo">Modelo</asp:ListItem>
            <asp:ListItem Value="marca">Marca</asp:ListItem>
            <asp:ListItem Value="año">Año</asp:ListItem>
            <asp:ListItem Value="placa">Placa</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:TextBox ID="txtbuscar" runat="server" Width="157px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        Height="218px" onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        Width="878px">
                        <Columns>
                            <asp:ButtonField CommandName="modificar" Text="Modificar" />
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="modelo" HeaderText="Modelo" />
                            <asp:BoundField DataField="marca" HeaderText="Marca" />
                            <asp:BoundField DataField="ano" HeaderText="Año" />
                            <asp:BoundField DataField="placa" HeaderText="Placa" />
                            <asp:BoundField DataField="valorKm" HeaderText="Valor Km" />
                            <asp:BoundField DataField="zona" HeaderText="Zona" />
                            <asp:BoundField DataField="chofer" HeaderText="Chofer" />
                            <asp:BoundField DataField="tipoUnidad" HeaderText="Tipo Unidad" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                  
                </td>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnrefrescar" runat="server" Text="Refrescar" Width="85px" />
                    <br />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style5">
                </td>
                <td class="style6">
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtcodigo" runat="server" Width="89px"></asp:TextBox>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblmodelo" runat="server" Text="Modelo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtmodelo" runat="server" Width="139px"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvmodelo" runat="server" 
                        ControlToValidate="txtmodelo" ErrorMessage="Ingrese un modelo de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblmarca" runat="server" Text="Marca"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtmarca" runat="server" Width="139px"></asp:TextBox>
&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvmarca" runat="server" 
                        ControlToValidate="txtmarca" ErrorMessage="Ingrese una marca de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblaño" runat="server" Text="Año (AAAA)"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtaño" runat="server" Width="89px" MaxLength="4"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvaño" runat="server" 
                        ControlToValidate="txtaño" ErrorMessage="Ingrese el año de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblplaca" runat="server" Text="Placa"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtplaca" runat="server" Width="65px" MaxLength="3"></asp:TextBox>
&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="-"></asp:Label>
&nbsp;
                    <asp:TextBox ID="txtplaca2" runat="server" Width="65px" MaxLength="4"></asp:TextBox>
&nbsp;
                    <asp:RequiredFieldValidator ID="rfvplaca" runat="server" 
                        ControlToValidate="txtplaca" ErrorMessage="Ingrese la placa de la unidad" 
                        ForeColor="#CC0000">  </asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="rfvplaca0" runat="server" 
                        ControlToValidate="txtplaca2" ErrorMessage="Ingrese la placa de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblvalorKm" runat="server" Text="Valor Km"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="txtvalorKm" runat="server" Width="89px"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvvalorKm" runat="server" 
                        ControlToValidate="txtvalorKm" ErrorMessage="Ingrese el valor por kilometros de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblzona" runat="server" Text="Zona"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtzona" runat="server" Width="146px"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvzona" runat="server" 
                        ControlToValidate="txtzona" ErrorMessage="Ingrese la zona de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lbltipounidad" runat="server" Text="Tipo Unidad"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="txttipounidad" runat="server" Width="146px"></asp:TextBox>
                &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvtipounidad" runat="server" 
                        ControlToValidate="txttipounidad" ErrorMessage="Ingrese el tipo de la unidad" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtestado" runat="server" Width="42px" MaxLength="1">A</asp:TextBox>
                &nbsp;&nbsp; </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnlimpiar" runat="server" Text="Limpiar" Width="85px" />
                </td>
                <td class="style6">
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
