<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="datos.aspx.cs" Inherits="amigo.Account.whatsapp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Crear una nueva cuenta</h1>
<fieldset class="register">
<legend>Datos de contacto</legend>
<p>

    <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label> <asp:TextBox ID="txtNombre"
        runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtNombre" ErrorMessage="*"></asp:RequiredFieldValidator>
   </p>
   <p>
        <asp:Label ID="Label2" runat="server" Text="Apellido: "></asp:Label> <asp:TextBox ID="txtApellido"
        runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtApellido" ErrorMessage="*"></asp:RequiredFieldValidator>
         </p>
   <p>
    <asp:Label ID="Label3" runat="server" Text="Celular: "></asp:Label> <asp:TextBox ID="txtCelular"
        runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
           ControlToValidate="txtCelular" ErrorMessage="*"></asp:RequiredFieldValidator>
         </p>
  <p>
    <asp:Button ID="Button1" runat="server" Text="Registrar" 
          onclick="Button1_Click" />
     </p>
     </fieldset>
</asp:Content>
