<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="contactanos.aspx.cs" Inherits="amigo.admin.comentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 80px;
        }
        .style2
        {
            width: 80px;
            height: 7px;
        }
        .style3
        {
            height: 7px;
        }
        .style4
        {
            width: 629px;
        }
        .style5
        {
            width: 101px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p style="height: 36px">
        &nbsp;&nbsp;
        <asp:Label ID="lblbuscar" runat="server" Text="Buscar por: "></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="ddlbuscar" runat="server">
            <asp:ListItem Value="codigo">Codigo</asp:ListItem>
            <asp:ListItem Value="nombre">Nombre</asp:ListItem>
            <asp:ListItem Value="correo">Correo</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:TextBox ID="txtbuscar" runat="server" Width="157px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnbuscar" runat="server" Text="Buscar" 
            onclick="btnbuscar_Click" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;
        <table style="width: 100%; height: 283px;">
            <tr>
                <td class="style1">
                    <asp:GridView ID="grvcontactanos" runat="server" AutoGenerateColumns="False" 
                        Height="130px" 
                        Width="921px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" 
                        BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" 
                        onrowcommand="grvcontactanos_RowCommand">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="correo" HeaderText="Correo" />
                            <asp:BoundField DataField="asunto" HeaderText="Asunto" />
                            <asp:BoundField DataField="mensaje" HeaderText="Mensaje" />
                            <asp:BoundField DataField="leido" HeaderText="Leido" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <table style="width: 1101%; height: 67px;">
                        <tr>
                            <td class="style4">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                                &nbsp;<asp:Button ID="btnrefrescar" runat="server" Height="42px" 
                        onclick="btnrefrescar_Click" Text="Refrescar" Width="108px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    </td>
                <td class="style3">
                   
                    </td>
            </tr>
            </table>
    </p>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
    
                    <asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtcodigo" runat="server" Width="77px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtnombre" runat="server" Width="144px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblcorreo" runat="server" Text="E-mail"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtcorreo" runat="server" Width="144px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblasunto" runat="server" Text="Asunto"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtasunto" runat="server" Width="144px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblmsj" runat="server" Text="Mensaje"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtmensaje" runat="server" TextMode="MultiLine" Width="295px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <asp:Label ID="lblleido" runat="server" Text="Leido"></asp:Label>
                </td>
                <td>
                    <br />
                    <asp:TextBox ID="txtleido" runat="server" Width="85px"></asp:TextBox>
                    <br />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblmensaje" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btneliminar" runat="server" Height="42px" 
                        onclick="btneliminar_Click" Text="Eliminar" Width="108px" />
                    &nbsp;</p>
    <p>
    </p>
</asp:Content>
