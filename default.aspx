<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="ManageGpuSpec" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="wrapper">
        
    <h1>About Us</h1>
<br />
    <p>This is online webstore that sells top of the line Nvidia Computer Graphic Cards. It is the most widely chosen GPU in the world when it comes to PC gaming. 
        We have a few variety of graphic cards over the past 2 generations. The store have from trop tier to medium tier and the lowest tier. The online store only sells
        MSI revamped Graphic cards from Nvidia.

    </p>

    <!-- image retrieved from gooogle -->
        <table>
        <tr>
            <td>
             <h1>GTX TITAN X</h1>
             <asp:Image ID="Image1" runat="server"  ImageUrl="~/Image/titan x.JPG" Width="300px" /><!-- Images retrieved from www.msi.com -->
            </td>
            <td>
                <h1>MSI GTX 1080ti</h1>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/1080ti.JPG" Width="325px" /><!-- Image retrieved from www.msi.com -->

            </td>
        </tr>

        </table>
</asp:Content>

