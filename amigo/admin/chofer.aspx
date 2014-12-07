<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="chofer.aspx.cs" Inherits="amigo.admin.chofer" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
    <style type="text/css">
        .style4
        {
            height: 100%;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

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
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" 
            CausesValidation="False" onclick="btnbuscar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="grvchofer" runat="server" AutoGenerateColumns="False" 
                        Height="130px" 
                        Width="1046px" BackColor="White" BorderColor="#999999" 
            BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
            GridLines="Vertical" onrowcommand="grvchofer_RowCommand">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
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
                        <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" BorderColor="#333333" Font-Bold="True" 
                            ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <PagerStyle BackColor="#999999" BorderColor="#333333" ForeColor="Black" 
                            HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" Width="108px" 
            Height="42px" CausesValidation="False" onclick="btnnuevo_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnrefrescar" runat="server" Text="Refrescar" 
            Width="108px" Height="42px" CausesValidation="False" 
            onclick="btnrefrescar_Click" />
    </p>
    <p>
        &nbsp;<tr><td class="style3"><asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtcodigo" runat="server" Width="89px"></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lbltipolicencia" runat="server" Text="Tipo de Licencia"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txttipolicencia" runat="server" Width="98px" MaxLength="1"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="revlicencia" runat="server" 
            ControlToValidate="txttipolicencia" 
            ErrorMessage="Ingrese solo el tipo de licencia" ForeColor="Red" 
            ValidationExpression="^[a-zA-Z ]*$">*</asp:RegularExpressionValidator>
        &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvtipolicencia" runat="server" 
                        ControlToValidate="txttipolicencia" ErrorMessage="Ingrese el tipo de licencia" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblcedula" runat="server" Text="Cedula"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtcedula" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;<asp:RegularExpressionValidator ID="revlicencia1" runat="server" 
            ControlToValidate="txtcedula" 
            ErrorMessage="Ingrese solo el tipo de licencia" ForeColor="Red" 
            ValidationExpression="\d{10}">A</asp:RegularExpressionValidator>
&nbsp;<asp:RequiredFieldValidator ID="rfvcedula" runat="server" 
                        ControlToValidate="txtcedula" ErrorMessage="Ingrese la cedula" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:TextBox ID="txtnombre" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;<asp:RegularExpressionValidator ID="revlicencia0" 
            runat="server" ControlToValidate="txtnombre" 
            ErrorMessage="Ingrese su nombre correctamente" ForeColor="Red" 
            ValidationExpression="^[a-zA-Z ]*$">*</asp:RegularExpressionValidator>
        &nbsp;
                    <asp:RequiredFieldValidator ID="rfvnombre" runat="server" 
                        ControlToValidate="txtnombre" ErrorMessage="Ingrese su nombre" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                <asp:ScriptManager ID="scl" runat="server" EnableScriptGlobalization="true"/>
                    <asp:Label ID="lblhoraEntrada" runat="server" Text="Hora entrada"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txthoraEntrada" runat="server" Width="89px"></asp:TextBox>
                <cc1:MaskedEditExtender ID="txthoraEntrada_MaskedEditExtender" 
            runat="server" TargetControlID="txthoraEntrada" MaskType="Time" Mask="99:99:99">
        </cc1:MaskedEditExtender>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvhentrada" runat="server" 
                        ControlToValidate="txthoraEntrada" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                &nbsp;<br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblhsalida" runat="server" Text="Hora salida"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txthsalida" runat="server" Width="89px"></asp:TextBox>
                <cc1:MaskedEditExtender ID="txthsalida_MaskedEditExtender" 
              runat="server" TargetControlID="txthsalida" MaskType="Time" Mask="99:99:99">
        </cc1:MaskedEditExtender>
                &nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvhsalida" runat="server" 
                        ControlToValidate="txthsalida" ErrorMessage="Ingrese la hora de salida" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lbltelefono" runat="server" Text="Telefono"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:TextBox ID="txttelefono" runat="server" Width="154px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;<asp:RegularExpressionValidator ID="revlicencia2" 
            runat="server" ControlToValidate="txttelefono" 
            ErrorMessage="Ingrese solo su numero de telefono" ForeColor="Red" 
            ValidationExpression="^[0-9]*">*</asp:RegularExpressionValidator>
&nbsp;<asp:RequiredFieldValidator ID="rfvtelefono" runat="server" 
                        ControlToValidate="txttelefono" ErrorMessage="Ingrese un telefono" 
                        ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:TextBox ID="txtestado" runat="server" Width="40px" MaxLength="1">A</asp:TextBox>
                &nbsp;&nbsp;<asp:RegularExpressionValidator ID="revlicencia3" 
            runat="server" ControlToValidate="txtestado" 
            ErrorMessage="Ingrese solo el estado" ForeColor="Red" 
            ValidationExpression="^[a-zA-Z ]*$">*</asp:RegularExpressionValidator>
        &nbsp; 
                    <br />
                    <br />
                </td>
                <td>
                
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList
        ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="UserName" DataValueField="UserId">
    </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" 
            SelectCommand="SELECT [UserName], [UserId] FROM [vw_aspnet_Users]">
        </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                <p>
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
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" 
            Width="108px" Height="42px" onclick="btngrabar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnlimpiar" 
            runat="server" Text="Limpiar" Width="108px" Height="42px" 
            CausesValidation="False" onclick="btnlimpiar_Click" />
                </p>
    
        <table style="width: 100%; height: 29px;">
            <tr>
                <td class="style4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                </td>
            </tr>
            </table>
  
</asp:Content>
