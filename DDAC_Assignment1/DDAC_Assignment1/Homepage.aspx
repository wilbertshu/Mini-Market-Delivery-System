<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="DDAC_Assignment1.Homepage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" Visible="False">
    <br />
    <asp:Label ID="lblUtype" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblUname" runat="server" Text="" Visible="False"></asp:Label>
    <br />
    <br />
    <div class="jumbotron">
        <h1>AlfaIndo Minimarket Delivery System</h1>
        <p class="lead">Where your item can be delivered online within certain time!</p>
        <p><a href="https://wilbertddac.blob.core.windows.net/ddacblob/Ads.jpg" class="btn btn-outline-info" target="_blank">To know more about us&raquo;</a></p>
    </div>
</asp:Content>
