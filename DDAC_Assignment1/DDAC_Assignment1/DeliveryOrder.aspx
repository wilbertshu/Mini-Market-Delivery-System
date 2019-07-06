<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryOrder.aspx.cs" Inherits="DDAC_Assignment1.DeliveryOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Delivery Orders</h2>
    <asp:Label ID="lblUname" runat="server" Visible="False"></asp:Label>
    <br />
    <asp:Panel ID="panelCheck" runat="server">
    <asp:Button ID="btnCheck" runat="server" class="btn btn-outline-info" Text="Click here to check" OnClick="btnCheck_Click" />
    </asp:Panel>
    <br />
    <asp:Panel ID="panelList" runat="server">&nbsp;<asp:GridView ID="deliveryOrder" CssClass="table table-bordered" runat="server"></asp:GridView>
    </asp:Panel>
    </asp:Content>
