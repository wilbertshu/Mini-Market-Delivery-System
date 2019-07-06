<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="DDAC_Assignment1.CheckOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Checkout</h2>
    <asp:Label ID="lblName" runat="server" Visible="False"></asp:Label>
    <br />
    <hr />
    <br />
    <asp:GridView ID="listCheckout" class="table table-bordered" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="btnAccept" class="btn btn-outline-info" runat="server" Text="Submit" OnClick="btnAccept_Click" />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=wilbertddac.database.windows.net;Initial Catalog=DDAC_Assignment;User ID=wilbertddac;Password=Wilbertcool10" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Orders] WHERE ([Fullname] = @Fullname)">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblName" Name="Fullname" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />

</asp:Content>
