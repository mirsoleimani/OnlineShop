<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopAdvancedAddressSearchBox.ascx.cs" Inherits="Modules_ShopAdvancedAddressSearch" %>
<asp:Panel runat="Server" DefaultButton="btnSearch">

<table  border="0" cellspacing="0" cellpadding="0" width="100%" dir="rtl" class="DefaultContent">
    <tr>
        <td class="DefaultTitle">
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lbl" runat="Server" Text="دسته:"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td class="DefaultData">
            <asp:DropDownList ID="ddlCategoryName" runat="Server" AutoPostBack="false">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td >
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblStateProvince" runat="Server" Text="استان:"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td >
            <asp:DropDownList ID="ddlStateProvince" runat="Server" AutoPostBack="false">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblCity" runat="Server" Text="شهر:"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td>
            <asp:TextBox ID="txtCity" runat="Server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblStreet" runat="Server" ToolTip="" Text="خيابان: "></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td>
            <asp:TextBox ID="txtStreet" runat="server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblBuilding" runat="Server" ToolTip="" Text="ساختمان:"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td>
            <asp:TextBox ID="txtBuilding" runat="server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
     <td>
     <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblPostalCode" runat="Server" Text="کدپستي(بدون خط تيره):"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td>
            <asp:TextBox ID="txtPostalCode" runat="Server" />
        </td>
       
    </tr>
        <tr>
        <td>
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="Label1" runat="Server" ToolTip="" Text="نام فروشگاه:"></asp:Label>
            <%--<img src="Icons/ico-help.gif" alt="" />--%>
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button ID="btnSearch" runat="server" Text="جستجو" OnClick="btnSearch_Click"
                ToolTip="جستجوي پيشرفته" />
        </td>
    </tr>
</table>
</asp:Panel>