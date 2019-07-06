<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuyItems.aspx.cs" Inherits="DDAC_Assignment1.BuyItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2>Buy Items</h2>
    <asp:Label ID="lblUname" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblAddress" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblPhone" runat="server" Visible="False"></asp:Label>
    <asp:Label ID="lblName" runat="server" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Item Type: "></asp:Label>
    <br />
    <asp:DropDownList ID="ddlItems" runat="server" DataSourceID="SqlDataSource1" DataTextField="Items" DataValueField="Items">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnSearch" runat="server" class="btn btn-outline-info" Text="Search" OnClick="btnSearch_Click" />
    <br />
    <br />

    <asp:Panel ID="panelMilk" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Milk</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image1" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Milk.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 12</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblMilk" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtMilk" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnMilk" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnMilk_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel_Click" /></td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="panelButter" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Butter</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image3" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Butter.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 7</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblButter" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtButter" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnButter" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnButter_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel2" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel2_Click" /></td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="panelBread" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Bread</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image4" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Bread.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 4</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblBread" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtBread" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnBread" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnBread_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel3" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel3_Click" /></td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="panelRice" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Rice</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image5" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Rice.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 18</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblRice" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtRice" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnRice" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnRice_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel4" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel4_Click" /></td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="panelSnack" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Snack</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image6" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Snack.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 5</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblSnack" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtSnack" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnSnack" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnSnack_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel5" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel5_Click" /></td>
            </tr>
        </table>
    </asp:Panel>

    <asp:Panel ID="panelDrink" runat="server" Visible="False">
        <hr />
        <table>
            <tr>
                <td style="width: 133px">Product Name:</td>
                <td style="width: 268px">&nbsp;Drink</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Image ID="Image7" runat="server" Height="156px" ImageUrl="https://wilbertddac.blob.core.windows.net/ddacblob/DDAC/Drinks.jpg" Width="167px" /></td>
            </tr>
            <tr>
                <td style="width: 133px">Price:</td>
                <td style="width: 268px">RM 8</td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td>
                    <asp:Label ID="lblDrink" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 133px">Quantity:</td>
                <td style="width: 268px"><asp:TextBox ID="txtDrink" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnDrink" CssClass="btn btn-outline-info" runat="server" Text="Add to Cart" OnClick="btnDrink_Click" /></td>
            </tr>
            <tr>
                <td style="width: 133px"></td>
                <td style="width: 268px"><asp:Button ID="btnCancel6" CssClass="btn btn-outline-danger" runat="server" Text="Cancel from Cart" OnClick="btnCancel6_Click" /></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=wilbertddac.database.windows.net;Initial Catalog=DDAC_Assignment;User ID=wilbertddac;Password=Wilbertcool10" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Items] FROM [Items]"></asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
