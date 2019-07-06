<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="DDAC_Assignment1.ManageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <h2>Manage User</h2>
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name :"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="BtnSearch" runat="server" class="btn btn-outline-info" Text="Search" OnClick="BtnSearch_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnList" runat="server" class="btn btn-outline-secondary" Text="Show List" OnClick="BtnList_Click" />
        <br />
        <br />
        <asp:Panel ID="PanelUser" runat="server">
            <hr />
            <br />
            <Table ID="Table1" runat="server">
            <tr>
                <td style="width: 91px">Name :</td>
                <td>
                    <asp:TextBox ID="txtFullname" runat="server" required="required" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">UserID :</td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server" required="required" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">Email :</td>
                <td>
                    <asp:TextBox ID="txtMail" runat="server" required="required" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">Phone :</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server" required="required" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">User Type :</td>
                <td>
                    <asp:TextBox ID="txtType" runat="server" ReadOnly="True" required="required"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px">Address :</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" required="required" Height="101px" TextMode="MultiLine" Width="254px" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 91px"></td>
                <td>
                    <asp:Button ID="BtnDelete" class="btn btn-outline-danger" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnCancel" runat="server" class="btn btn-outline-primary" Text="Cancel" />
                </td>
            </tr>
            </Table>
        </asp:Panel>

        <asp:Panel ID="PanelList" runat="server">
            <hr />
            <br />
            <asp:GridView ID="userList" class="table table-bordered" runat="server"></asp:GridView>
        </asp:Panel>
</asp:Content>
