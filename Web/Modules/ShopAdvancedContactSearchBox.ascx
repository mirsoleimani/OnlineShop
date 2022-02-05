<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopAdvancedContactSearchBox.ascx.cs" Inherits="Modules_ShopAdvancedContactSearch" %>
<asp:Panel runat="Server" DefaultButton="btnSearch">
<table  border="0" cellspacing="0" cellpadding="0" width="100%" dir="rtl" class="DefaultContent">
    <tr>
        <td class="DefaultTitle">
        <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lbl" runat="Server" Text="دسته:"></asp:Label>
           
        </td>
        <td class="DefaultData" >
            <asp:DropDownList ID="ddlCategoryName" runat="Server" AutoPostBack="false">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblArea" runat="Server" Text="کدشهر:"></asp:Label>
           
        </td>
        <td>
            <asp:TextBox ID="txtAreaCode" runat="Server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblPhone" runat="Server" ToolTip="" Text="سه رقم اول شماره تلفن(منطقه مخابراتي): "></asp:Label>
            
        </td>
        <td>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="textbox" />
        </td>
    </tr>
        <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="Label1" runat="Server" ToolTip="" Text="نام فروشگاه:"></asp:Label>
            
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