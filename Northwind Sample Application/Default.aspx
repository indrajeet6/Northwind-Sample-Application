<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Northwind_Sample_Application._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Northwind Sample Application</h1>
    </div>
    <div class="jumbotron">

        <asp:Login ID="Login1" runat="server" BorderStyle="None" DisplayRememberMe ="false" TitleText="" OnAuthenticate="Login1_Authenticate" >
        </asp:Login>

    </div>

</asp:Content>
