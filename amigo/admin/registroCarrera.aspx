<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="registroCarrera.aspx.cs" Inherits="amigo.admin.registroCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <p>
        <br />
    </p>
    <p>
        &nbsp; &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblbuscar" runat="server" Text="Buscar por: "></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="ddlbuscar" runat="server">
            <asp:ListItem Value="id">Codigo</asp:ListItem>
            <asp:ListItem Value="activa">Activa</asp:ListItem>
            <asp:ListItem Value="valorAprox">Costo</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtbuscar" runat="server" Width="180px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Bbuscar" runat="server" onclick="Bbuscar_Click" Text="Buscar" 
            Width="90px" />
    </p>
    <asp:GridView ID="gvrcarreras" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" 
        AutoGenerateColumns="False" Height="198px" 
        onrowcommand="gvrcarreras_RowCommand">
        <Columns>
            <asp:ButtonField CommandName="modificar" Text="Modificar" />
            <asp:BoundField DataField="id" HeaderText="Codigo" />
            <asp:BoundField DataField="UserName" HeaderText="Nombre" />
            <asp:BoundField DataField="km" HeaderText="Distancia" />
            <asp:BoundField DataField="direccion" HeaderText="Direccion O" />
            <asp:BoundField DataField="nombre_zona" HeaderText="Zona O" />
            <asp:BoundField DataField="ciudadela" HeaderText="Ciudadela O." />
            <asp:BoundField DataField="direccionllegada" HeaderText="Direccion D." />
            <asp:BoundField DataField="zonallegada" HeaderText="Zona D" />
            <asp:BoundField DataField="ciudadelallegada" HeaderText="Ciudadela D" />
            <asp:BoundField DataField="valorAprox" HeaderText="Valor" />
            <asp:BoundField DataField="fecha" HeaderText="Fecha" />
            <asp:BoundField DataField="modelo" HeaderText="Unidad" />
            <asp:BoundField DataField="nombre_servicio" HeaderText="Servicio" />
            <asp:BoundField DataField="tipo" HeaderText="T Unidad" />
            <asp:BoundField DataField="activa" HeaderText="Estado" />
            <asp:BoundField DataField="nombre" HeaderText="Chofer" />
            <asp:ButtonField CommandName="eliminar" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Bnuevo" runat="server" Text="Nuevo" Height="35px" 
            Width="115px" onclick="Bnuevo_Click" />
    &nbsp;&nbsp;
        <asp:Button ID="Brefrescar" runat="server" Text="Refrescar" Height="35px" 
            Width="115px" onclick="Brefrescar_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp; &nbsp;<asp:Label ID="lblcodigo" runat="server" Text="Codigo"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcodigo" runat="server" Width="82px"></asp:TextBox>
    &nbsp;&nbsp;
    </p>
    <p>
        &nbsp;&nbsp; <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        &nbsp;<asp:DropDownList ID="ddlnombre" runat="server">
        </asp:DropDownList>
        &nbsp;
    </p>
    <p>
        &nbsp; <asp:Label ID="lbldistancia" runat="server" Text="Distancia"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtdistancia" runat="server" Width="81px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Label ID="lbldireccion" runat="server" Text="Direccion"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblzona" runat="server" Text="Zona"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlzona" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlzona_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblciudadela" runat="server" Text="Ciudadela"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="ddlciudadela" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Label ID="lbldestino" runat="server" Text="DESTINO"></asp:Label>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblzona1" runat="server" Text="Zona"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="ddlzonallegada" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlzonallegada_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Label ID="lblciudadelallegada" runat="server" Text="Ciudadela "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlciudadelallegada" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;<asp:Label ID="lbldireccionllegada" runat="server" Text="Direccion"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtdireccionllegada" runat="server" ontextchanged="txtvalor_TextChanged" 
            Width="87px"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblvalor" runat="server" Text="Valor"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtvalor" runat="server" ontextchanged="txtvalor_TextChanged" 
            Width="87px"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblfecha" runat="server" Text="Fecha"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtfecha" runat="server" ontextchanged="txtfecha_TextChanged" 
            Width="86px"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblunidad" runat="server" Text="Unidad"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="ddlunidad" runat="server">
        </asp:DropDownList>
    </p>
    <p>
    &nbsp;&nbsp; <asp:Label ID="lblservicio" runat="server" Text="Servicio"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="ddlservicio" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp; <asp:Label ID="lbltipoUnidad" runat="server" Text="Tipo Unidad"></asp:Label>
        &nbsp;&nbsp;
        <asp:DropDownList ID="ddltipoUnidad" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp; <asp:Label ID="lblestadocarrera" runat="server" Text="Estado Carrera"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtestadocarrera" runat="server" ontextchanged="txtfecha_TextChanged" 
            Width="53px"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblestado" runat="server" Text="Estado "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtestado" runat="server" ontextchanged="txtfecha_TextChanged" 
            Width="53px"></asp:TextBox>
    </p>
    <p>
        &nbsp; <asp:Label ID="lblchfofer" runat="server" Text="Chofer"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlchofer" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="lblmensaje" runat="server" Text=" "></asp:Label>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;<asp:Button ID="Bgrabar" runat="server" onclick="Bgrabar_Click" 
            Text="Grabar" Height="36px" Width="114px" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Blimpiar" runat="server" Text="Limpiar" Height="36px" 
            Width="114px" onclick="Blimpiar_Click" />
    </p>
    <p>
    </p>

</asp:Content>
