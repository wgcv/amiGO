<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="solicitar.aspx.cs" Inherits="amigo.solicitar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

<script type="text/javascript"
      src="http://maps.googleapis.com/maps/api/js?key=AIzaSyDVuND2HGk8qudUg74rqyRyOLEzFu-GrG8&sensor=falsee&region=EC">
    </script>
     <script type="text/javascript"
     src="Scripts/localizacion.js">

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div id="map-canvas"></div>
    <p>Total Distance: <asp:Label ID="total" runat="server" Text="0"></asp:Label> 
        <asp:Label ID="Label1" runat="server" Text=" Km"></asp:Label>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </p>
</asp:Content>
