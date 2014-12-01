<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="contactanos.aspx.cs" Inherits="amigo.contactanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 886px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Image ID="Image1" runat="server" ImageUrl="/images/contact.jpg"
     />
     <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="Label1" runat="server" 
                    Text="Si desea comunicarse con nosotros, solicitar información, realizar denuncias o consultar tarifas, dirigirse a los responsables de cada área a través de este formulario y correo electrónico:"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Su nombre"></asp:Label>
&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rfvnombre" runat="server" 
                    ControlToValidate="txtnombre" ErrorMessage="Ingrese su nombre " 
                    Font-Bold="True" ForeColor="#990000">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:TextBox ID="txtnombre" runat="server" MaxLength="30" Width="50%"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
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
                <asp:Label ID="Label3" runat="server" Font-Bold="True" 
                    Text="Su dirección de correo electrónico"></asp:Label>
&nbsp;
                <asp:RequiredFieldValidator ID="rfvemail" runat="server" 
                    ControlToValidate="txtemail" ErrorMessage="Ingrese su correo electronico" 
                    Font-Bold="True" ForeColor="#990000">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:TextBox ID="txtemail" runat="server" MaxLength="30" Width="50%"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
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
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Asunto"></asp:Label>
&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rfvasunto" runat="server" 
                    ControlToValidate="txtasunto" ErrorMessage="Ingrese el asunto" Font-Bold="True" 
                    ForeColor="#990000">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:TextBox ID="txtasunto" runat="server" MaxLength="15" Width="50%"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
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
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Mensaje"></asp:Label>
&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rfvmensaje" runat="server" 
                    ControlToValidate="txtasunto" ErrorMessage="Ingrese el mensaje" 
                    Font-Bold="True" ForeColor="#990000">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:TextBox ID="txtmensaje" runat="server" Height="150px" MaxLength="500" 
                    Width="100%"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1"><center>
                &nbsp;<asp:Button ID="btnenviarmensaje" runat="server" Height="32px" 
                    Text="Enviar mensaje" Width="217px" /></center>
            &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
