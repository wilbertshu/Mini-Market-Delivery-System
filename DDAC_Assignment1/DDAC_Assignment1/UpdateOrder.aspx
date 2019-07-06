<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateOrder.aspx.cs" Inherits="DDAC_Assignment1.UpdateOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Update Order</h2>
    <asp:Label ID="lblUname" runat="server" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Receiver Name: "></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <br />
    <hr />
    <asp:GridView ID="updateOrder" class="table table-bordered" runat="server"></asp:GridView>
    <br />
    <hr />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-outline-info" OnClick="btnUpdate_Click" />
</asp:Content>
