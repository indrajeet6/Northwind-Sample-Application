<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Northwind_Sample_Application._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Northwind Sample Application</h1>
    </div>
    <div class="jumbotron">

        <table class="nav-justified">
            <tr>
                <td style="width: 79px; height: 40px;"><strong>Login ID</strong></td>
                <td style="height: 40px">
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 79px; height: 40px"><strong>Password</strong></td>
                <td style="height: 42px">
                    <asp:TextBox ID="Password" runat="server" TextMode ="password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 79px" >
                    <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Login" Width="165px" />
                </td>
                <td >
                    <asp:Button ID="Button2" runat="server" Height="29px" Text="New User" OnClick="Button2_Click" Width="131px" />
                </td>
            </tr>
        </table>

    </div>

</asp:Content>
