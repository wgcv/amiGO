<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="nosotros.aspx.cs" Inherits="amigo.nosotros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
            width: 841px;
        }
    .style2
    {
        width: 841px;
        height: 99px;
    }
    .style3
    {
        height: 99px;
        font-weight: 700;
    }
    .style4
    {
        width: 841px;
        height: 36px;
    }
    .style5
    {
        height: 36px;
    }
    .style8
    {
            width: 841px;
            height: 18px;
        }
    .style9
    {
        height: 18px;
    }
        .style10
        {
            height: 99px;
            font-weight: 700;
            width: 841px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<asp:Image ID="Image1" runat="server" ImageUrl="~/images/city.png" 
        Width="881px" />
    <br />
    <table style="width:100%;">
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="Misión" ForeColor="#F5CC00"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style8">
        </td>
        <td class="style9">
        </td>
        <td class="style9">
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label2" runat="server" 
                Text="Ser la empresa líder en la ciudad ofreciendo los más altos índices de seguridad con un parque automotor en óptimas condiciones de mecánica, higiene, seguridad y comodidad conducidos por personas idóneas y previamente capacitadas para el cumplimiento de su labor."></asp:Label>
        </td>
        <td class="style3">
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" 
                Text="Visión" ForeColor="#F5CC00"></asp:Label>
        </td>
        <td class="style5">
        </td>
        <td class="style5">
        </td>
    </tr>
    <tr>
        <td class="style8">
        </td>
        <td class="style9">
        </td>
        <td class="style9">
        </td>
    </tr>
    <tr>
        <td class="style10">
            <asp:Label ID="Label4" runat="server" Font-Bold="False" 
                Text="TRANSPORTE AMIGO S.A. es y continuara siendo reconocida como la empresa que ofrece las mejores garantías y oportunidades de movilización en razón a vehículos en óptimo estado, recurso humano de conductores  aptos en la labor de conducción y con una estructura técnico administrativa que responde a las exigencias de una sociedad moderna."></asp:Label>
        </td>
    </tr>
</table>

</asp:Content>
