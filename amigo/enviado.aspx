<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="enviado.aspx.cs" Inherits="amigo.enviado" %>
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
     <h1>Su mensaje fue enviado, gracias por contactarnos!</h1>
</asp:Content>
