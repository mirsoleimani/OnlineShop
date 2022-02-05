<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopAdvancedCareerSearchBox.ascx.cs" Inherits="Modules_ShopAdvancedCareerSearchBox" %>
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
            <asp:Label ID="lblDeputation" runat="Server" Text="نمايندگي:"></asp:Label>
           
        </td>
        <td>
            <asp:TextBox ID="txtDeputation" runat="Server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblActivityType" runat="Server" ToolTip="" Text="نوع فعاليت: "></asp:Label>
            
        </td>
        <td>
            <asp:TextBox ID="txtActivityType" runat="server" CssClass="textbox" />
        </td>
    </tr>
    <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="lblActivityField" runat="Server" ToolTip="" Text="زمينه ي فعاليت: "></asp:Label>
            
        </td>
        <td>
            <asp:TextBox ID="txtActivityField" runat="server" CssClass="textbox" />
        </td>
    </tr>
        <tr>
        <td>
          <img src="App_Themes/OnlineShopDefault/Images/Question.png" alt="" />
            <asp:Label ID="LabelName" runat="Server" ToolTip="" Text="نام فروشگاه:"></asp:Label>
            
        </td>
        <td>
            <asp:TextBox ID="TextName" runat="server" CssClass="textbox" />
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