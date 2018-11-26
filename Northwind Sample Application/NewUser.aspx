<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Northwind_Sample_Application.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Northwind Sample Application</h1>
    </div>
    <div class="jumbotron">

        <table class="nav-justified">
            <tr>
                <td style="width: 115px; height: 40px;"><strong>Login ID</strong></td>
                <td style="height: 40px">
                    <asp:TextBox ID="UserName" runat="server" Height="22px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 115px; height: 40px"><strong>Password</strong></td>
                <td style="height: 42px">
                    <asp:TextBox ID="Password" runat="server" TextMode ="password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td ><strong>Role</strong></td>
                <td >
                    <asp:DropDownList ID="RoleList" runat="server" Font-Bold="True">
                        <asp:ListItem>Clerk</asp:ListItem>
                        <asp:ListItem>Manager</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan =" 2" style="height: 42px">
                    <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" Text="Create User" Width="245px" />
                </td>
            </tr>
        </table>

    </div>

</asp:Content>