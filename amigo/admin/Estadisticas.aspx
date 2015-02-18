<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Estadisticas.aspx.cs" Inherits="amigo.Estadisticas" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Lblchof" runat="server" Text="TOP CHOFERES"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LblUnidad" runat="server" Text="TOP UNIDADES"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Chart ID="ChtChofer" runat="server">
                <series>
                    <asp:Series Name="Series1" ChartType="Bubble" YValuesPerPoint="2">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </td>
        <td>
            <asp:Chart ID="ChtUnidad" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Lblservicio" runat="server" Text="TOP SERVICIOS"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Lblzona" runat="server" Text="TOP ZONAS"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Chart ID="ChtServicio" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </td>
        <td>
            <asp:Chart ID="ChtZona" runat="server">
                <series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
        </td>
    </tr>
</table>
</asp:Content>
