<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Search.ascx.cs" Inherits="Modules_Search" %>

<script src="Scripts/ConvertLanguage.js" type="text/javascript"></script>

<script type="text/javascript" src="Scripts/wz_tooltip.js"></script>

<table border="0" cellspacing="0" cellpadding="0" width="100%" style="padding-top:5px;">
    <tr align="center">
        <td>
            <table border="0"  cellpadding="0" style="border:solid 1px silver;">
                <tr >
                    <td align="right" valign="top">
                        <asp:TextBox runat="Server" CssClass="searchtextbox" ID="txtSearch" onkeypress="return convert(name,event)" />
                    </td>
                    <td align="left" valign="bottom">
                        <asp:Button runat="Server" ID="btnSearch" CssClass="searchButton" Text="جـستـجـو" onmouseover="this.style.cursor='pointer';this.style.color='red'"
                            onmouseout="this.style.color='white'" />
                    </td>
                </tr>
                <tr valign="top">
                    <td align="left" valign="top">
                        <input type="button" style="background-image: url(App_Themes/OnlineShopDefault/Images/ico-help.png);
                            opacity: .7;  border: 1px; background-repeat: no-repeat;
                            height:20px; width:20px;" onclick="change(<%=txtSearch.ClientID.ToString()%>)" 
                            onmouseover="this.style.cursor='pointer';Tip('فارسي/لاتين',SHADOW, true,BGCOLOR, '#ffffff',FONTFACE, 'Arial, Helvetica, sans-serif', FONTSIZE, '10pt',FONTWEIGHT,'bold')"
                            onmouseout="UnTip();" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
