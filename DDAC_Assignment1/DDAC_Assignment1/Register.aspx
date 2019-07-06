<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DDAC_Assignment1.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <h2>Register Page</h2>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtName" ErrorMessage="Name must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
        <br />
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUser" ErrorMessage="Username must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPass" ErrorMessage="Password must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="txtMail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMail" ErrorMessage="Email must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Phone Number"></asp:Label>
        <br />
        <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" ></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone number must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Home Address"></asp:Label>
        <br />
        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Height="63px" Width="204px" ></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label7" runat="server" Text="User Type"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlUserType" runat="server">
            <asp:ListItem>Customer</asp:ListItem>
            <asp:ListItem>Delivery</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" class="btn btn-outline-primary" OnClick="BtnSubmit_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" class="btn btn-outline-danger" OnClick="BtnCancel_Click" />

        <br />

    </div>
</asp:Content>
