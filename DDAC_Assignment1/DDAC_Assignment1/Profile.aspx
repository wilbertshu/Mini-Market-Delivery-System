<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="DDAC_Assignment1.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <h2>My Profile</h2>
        <p>Fullname</p>
        <asp:TextBox ID="txtName" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
        <br />
        <p>Username</p>
        <asp:TextBox ID="txtUser" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
        <br />
        <p>Email</p>
        <asp:TextBox ID="txtMail" runat="server" Enabled="False" ReadOnly="True" TextMode="Email"></asp:TextBox>
        <br />
        <p>Phone</p>
        <asp:TextBox ID="txtPhone" runat="server" Enabled="False" ReadOnly="True" TextMode="Email"></asp:TextBox>
        <br />
        <hr />
        <p>&nbsp;Address</p>
        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Enabled="False" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <hr />
        <br />
        <p>Change Password</p>
        <asp:TextBox ID="txtChange" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <p>Confirm Password</p>
        <asp:TextBox ID="txtChange2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtChange" ControlToValidate="txtChange2" ErrorMessage="Password mis-match!" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <hr />
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-outline-primary" OnClick="btnUpdate_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" class="btn btn-outline-danger" Text="Cancel" OnClick="btnCancel_Click" />
        <br />
    </div>
</asp:Content>
