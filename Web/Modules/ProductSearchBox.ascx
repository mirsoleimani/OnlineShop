﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductSearchBox.ascx.cs"
    Inherits="Modules_ProductSearchBox" %>
<asp:Panel runat="Server" ID="pnlShopSearchBox" DefaultButton="ibtnSearch">
    <table border="0" cellpadding="0" >
        <tr class="" align="right">
            <td align="right" valign="middle"  >
                <asp:TextBox runat="Server"  Width="100%" ID="txtSearch" />
                
            </td>
            <td align="left" valign="bottom" >
                <asp:ImageButton runat="Server" ID="ibtnSearch" ImageUrl="~/App_Themes/OnlineShopDefault/Images/Search.png"
                    OnClick="ibtnSearch_Click" ToolTip="جستجو" />
            </td>
        </tr>
        <tr valign="top" dir="rtl">
            <td align="center" valign="top">
                <asp:CheckBox runat="Server" ForeColor="Yellow" Font-Names="Tahoma" Font-Size="9pt" 
                    Font-Bold="false" ID="cbAllWords" Text="براي تمام کلمات جستجو کن" />
            </td>
        </tr>
    </table>
</asp:Panel>
