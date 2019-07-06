<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="DDAC_Assignment1.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <br />
        <h2>Order List</h2>
        <br />
        Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="BtnSearch" runat="server" class="btn btn-outline-info" Text="Search" OnClick="BtnSearch_Click" />
        <br />
        <asp:Panel ID="panelTable" runat="server">
            <hr />
            <br />
           <asp:GridView class="table table-bordered" ID="searchResult" runat="server">
           </asp:GridView>
        </asp:Panel>
    </div>
</asp:Content>
