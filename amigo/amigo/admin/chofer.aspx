<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="chofer.aspx.cs" Inherits="amigo.admin.chofer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 70px;
        }
        .style3
        {
            height: 37px;
        }
        .style4
        {
            height: 36px;
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
            <asp:ListItem Value="tipoLicencia">Tipo de Licencia</asp:ListItem>
            <asp:ListItem Value="cedula">Cedula</asp:ListItem>
            <asp:ListItem Value="nombre">Nombre</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:TextBox ID="txtbuscar" runat="server" Width="157px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" />
    </p>
    <p>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                            <asp:BoundField DataField="tipoLicencia" HeaderText="Tipo de Licencia" />
                            <asp:BoundField DataField="cedula" HeaderText="Cedula" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="horaEntrada" HeaderText="Hora Entrada" />
                            <asp:BoundField DataField="horaSalida" HeaderText="Hora Salida" />
                            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                            <asp:BoundField DataField="estado" HeaderText="Estado" />
                            <asp:BoundField DataField="userId" HeaderText="Usuario Id" />
                            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
&nbsp;&nbsp;</p>
    <p>
        <table style="width: 100%; height: 29px;">
            <tr>
                <td class="style4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnrefrescar" runat="server" Text="Refrescar" Width="85px" />
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtcodigo" runat="server" Width="89px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lbltipolicencia" runat="server" Text="Tipo de Licencia"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="txttipolicencia" runat="server" Width="98px" MaxLength="1"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvtipolicencia" runat="server" 
                        ControlToValidate="txttipolicencia" ErrorMessage="Ingrese el tipo de licencia" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lbltipolicencia0" runat="server" Text="Cedula"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtcedula" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvcedula" runat="server" 
                        ControlToValidate="txtcedula" ErrorMessage="Ingrese la cedula" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtnombre" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvnombre" runat="server" 
                        ControlToValidate="txtnombre" ErrorMessage="Ingrese el nombre del chofer" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblnombre0" runat="server" Text="Hora entrada"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txthentrada" runat="server" Width="89px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvhentrada" runat="server" 
                        ControlToValidate="txthentrada" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblhsalida" runat="server" Text="Hora salida"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txthsalida" runat="server" Width="89px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvhsalida" runat="server" 
                        ControlToValidate="txthsalida" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lbltelefono" runat="server" Text="Telefono"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txttelefono" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvhsalida0" runat="server" 
                        ControlToValidate="txthsalida" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtestado" runat="server" Width="40px" MaxLength="1">A</asp:TextBox>
                &nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblusuario" runat="server" Text="Usuario Id"></asp:Label>
&nbsp;&nbsp;
                    <asp:TextBox ID="txtusuarioid" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvusuario" runat="server" 
                        ControlToValidate="txtusuarioid" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;<asp:Button ID="btnlimpiar" runat="server" Text="Limpiar" Width="85px" />
                </td>
            </tr>
        </table>
    </p>
    <p>
    </p>
</asp:Content>
