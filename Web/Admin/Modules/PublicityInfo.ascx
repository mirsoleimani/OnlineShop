<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PublicityInfo.ascx.cs"
    Inherits="Admin_Modules_PublicityInfo" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%" dir="rtl">
    <tr>
    <td class="adminTitle">
    <img src="Icons/ico-help.gif" alt="">
            <asp:Label runat="Server" ID="lblPublicityShop" Text="فروشگاه بخش بازاريابي:" ToolTip="فروشگاه بازاريابي "></asp:Label>
            
        </td>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlShops" AutoPostBack="false" CssClass="adminInput">
            </asp:DropDownList>
        </td>
        
    </tr>
</table>
