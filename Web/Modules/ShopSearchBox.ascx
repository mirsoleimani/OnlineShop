<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopSearchBox.ascx.cs"
    Inherits="Modules_ShopSearchBox" %>
<%--<script src="Scripts/ConvertLanguage.js" type="text/javascript"></script>

<script type="text/javascript" src="Scripts/wz_tooltip.js"></script>--%>
<asp:Panel runat="Server" ID="pnlShopSearchBox" DefaultButton="ibtnSearch">
    <table border="0" cellpadding="0" style="height:50px">
        <tr>
            <td align="right" valign="middle">
                <asp:TextBox runat="Server" Width="200px" ID="txtSearch" />
            </td>
            <td align="left" valign="bottom">
                <asp:ImageButton runat="Server" ID="ibtnSearch" ImageUrl="~/App_Themes/OnlineShopDefault/Images/Search.png"
                    OnClick="ibtnSearch_Click" ToolTip="جستجو" />
            </td>
        </tr>
        <tr valign="top" dir="rtl">
            <td align="center" valign="top">
                <asp:CheckBox runat="Server" ForeColor="Yellow" Font-Names="Tahoma" Font-Size="7pt"
                    Font-Bold="false" ID="cbAllWords" Text="براي تمام کلمات جستجو کن" />
            </td>
        </tr>
    </table>
</asp:Panel>
