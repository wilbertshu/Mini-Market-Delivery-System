<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageOrders.aspx.cs" Inherits="DDAC_Assignment1.ManageOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <br />
        <h2>Manage Orders</h2>
        <br />
        Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="BtnSearch" runat="server" class="btn btn-outline-info" Text="Search" OnClick="BtnSearch_Click" />
        <br />
        <asp:Panel ID="panelTable" runat="server">
            <hr />
            <br />
           <asp:GridView CssClass="table table-bordered" ID="searchResult" runat="server">
           </asp:GridView>
            <hr />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Sender Name:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlDelivery" runat="server" DataSourceID="SqlDataSource1" DataTextField="Fullname" DataValueField="Fullname"></asp:DropDownList>
            <br />
            <br />
           <asp:Button ID="BtnConfirm" runat="server" class="btn btn-outline-info" Text="Confirm" OnClick="BtnConfirm_Click" />&nbsp;&nbsp;
           <asp:Button ID="BtnBack" runat="server" class="btn btn-outline-danger" Text="Back" OnClick="BtnBack_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=wilbertddac.database.windows.net;Initial Catalog=DDAC_Assignment;Persist Security Info=True;User ID=wilbertddac;Password=Wilbertcool10" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Fullname] FROM [Users] WHERE ([Usertype] = @Usertype)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlDelivery" DefaultValue="Delivery" Name="Usertype" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
        </asp:Panel>
    </div>
</asp:Content>
