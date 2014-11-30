<%@ Page Title="" Language="C#" MasterPageFile="~/page.Master" AutoEventWireup="true" CodeBehind="unidades.aspx.cs" Inherits="amigo.unidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 219px;
        }
        .style3
        {
            width: 219px;
            height: 31px;
        }
        .style5
        {
            height: 31px;
            width: 275px;
        }
        .style9
        {
            width: 275px;
        }
        .style10
        {
            width: 219px;
            height: 76px;
        }
        .style12
        {
            width: 275px;
            height: 76px;
        }
        .style13
        {
            height: 31px;
            width: 330px;
        }
        .style14
        {
            width: 330px;
        }
        .style15
        {
            width: 330px;
            height: 76px;
        }
        .style16
        {
            width: 219px;
            height: 56px;
        }
        .style17
        {
            width: 330px;
            height: 56px;
        }
        .style18
        {
            width: 275px;
            height: 56px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="Image1" runat="server" ImageUrl="/images/unidades.jpg" 
        Width="881px" />
    <br />
    <br />
&nbsp;<table style="width:100%;">
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;</td>
            <td class="style13">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" 
                    ForeColor="#2B2B2B" Text="SEDAN" Font-Size="XX-Large"></asp:Label>
            </td>
            <td class="style5">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/sedan1.png" />
            </td>
            <td class="style14">
                <br />
               
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/sdan2.png" />
                <br />
                <br />
                
                
            </td>
            <td class="style9">
                <asp:Image ID="Image4" runat="server" ImageUrl="~/images/sdan3.png" 
                    Height="150px" Width="289px" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image5" runat="server" ImageUrl="/images/sedan4.png" />
            </td>
            <td class="style14">
                <asp:Image ID="Image6" runat="server" ImageUrl="/images/sedan5.png" />
            </td>
            <td class="style9">
                <asp:Image ID="Image7" runat="server" ImageUrl="/images/sedan6.png" 
                    Height="150px" Width="289px" />
            </td>
        </tr>
        <tr>
            <td class="style10">
                </td>
            <td class="style15">
                </td>
            <td class="style12">
                </td>
        </tr>
        <tr>
            <td class="style16">
                </td>
            <td class="style17">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                    ForeColor="#2B2B2B" Text="4 x 4" Font-Size="XX-Large"></asp:Label>
            </td>
            <td class="style18">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image8" runat="server" ImageUrl="/images/4x41.png" />
            </td>
            <td class="style14">
                <asp:Image ID="Image9" runat="server" ImageUrl="/images/4x42.png" />
            </td>
            <td class="style9">
                <asp:Image ID="Image10" runat="server" ImageUrl="/images/4x43.png" 
                  Height="150px" Width="289px" />
            </td>
        </tr>
        <tr>
            <td class="style10">
                </td>
            <td class="style15">
                </td>
            <td class="style12">
                </td>
        </tr>
        <tr>
            <td class="style16">
                </td>
            <td class="style17">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Font-Bold="True" 
                    ForeColor="#2B2B2B" Text="Camionetas" Font-Size="XX-Large"></asp:Label>
                </td>
            <td class="style18">
                </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Image ID="Image16" runat="server" ImageUrl="/images/camioneta1.png" />
                </td>
            <td class="style15">
                <asp:Image ID="Image17" runat="server" ImageUrl="/images/camioneta2.png" />
                </td>
            <td class="style12">
                <asp:Image ID="Image18" runat="server" ImageUrl="/images/camioneta3.png" 
                 Height="150px" Width="289px" />
                </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style15">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style16">
                &nbsp;</td>
            <td class="style17">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Font-Bold="True" 
                    ForeColor="#2B2B2B" Text="Vans" Font-Size="XX-Large"></asp:Label>
                </td>
            <td class="style18">
                </td>
        </tr>
        <tr>
            <td class="style16">
                <asp:Image ID="Image19" runat="server" ImageUrl="/images/van1.png" />
                </td>
            <td class="style17">
                <asp:Image ID="Image20" runat="server" ImageUrl="/images/van2.png" />
                </td>
            <td class="style18">
                <asp:Image ID="Image21" runat="server" ImageUrl="/images/van3.png" 
                 Height="150px" Width="289px" />
                </td>
        </tr>
        <tr>
            <td class="style10">
                </td>
            <td class="style15">
                </td>
            <td class="style12">
                </td>
        </tr>
        <tr>
            <td class="style16">
                </td>
            <td class="style17">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" 
                    ForeColor="#2B2B2B" Text="Limusinas y Clásicos" Font-Size="X-Large"></asp:Label>
            </td>
            <td class="style18">
                </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image11" runat="server" ImageUrl="/images/clas1.png" />
            </td>
            <td class="style14">
                <asp:Image ID="Image12" runat="server" ImageUrl="/images/clas2.png" />
            </td>
            <td class="style9">
                <asp:Image ID="Image13" runat="server" ImageUrl="/images/clas3.png" 
                Height="150px" Width="289px" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Image ID="Image14" runat="server" ImageUrl="/images/limo1.png" />
            </td>
            <td class="style14">
                <asp:Image ID="Image15" runat="server" ImageUrl="/images/limo2.png" />
            </td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
