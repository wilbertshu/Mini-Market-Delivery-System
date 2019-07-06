<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DDAC_Assignment1.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <h2>Login Page</h2>
        Login as Admin<br />
        Username : Admin<br />
        Password: Admin123<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
        <br />
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-outline-primary"  OnClick="btnSubmit_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" class="btn btn-outline-danger" Text="Cancel" OnClick="btnCancel_Click"/>
    </div>
</asp:Content>
