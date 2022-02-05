<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopQuickAccess.ascx.cs"
    Inherits="Modules_ShopQuickAccess" %>
    <asp:Panel runat="Server" id="pnlQuickAccess" DefaultButton="ibtnGo">
<table style="border: solid 0px White; height:80px;text-align:center;margin-left:5px; " cellspacing="0"
    cellpadding="0" width="120px">
    <tr>
        <td colspan="2" style="; color: White; font-family: Tahoma; font-size: 9pt">
            <asp:Label ID="lblMessage1" runat="Server" Text="دسترسي از طريق شماره تماس"></asp:Label>
        </td>
    </tr>
    <tr align="center" >
    <td colspan="2">
    <table border="0" cellspacing="0" cellpadding="0"  dir="rtl" style="border:1px solid #000000;">
    	<tr >
    	
    		<td align="left" valign="middle" style="padding-right:2px;">
            <asp:TextBox runat="Server" ID="txtCode" CssClass="QuickTextBox" ToolTip="تلفن فروشگاه را به همراه کد شهر را وارد کنيد"
              ValidationGroup="QuickAcces"></asp:TextBox>
        </td>
        <td align="right" valign="middle" style="padding-top:2px;">
           <%-- <asp:Button runat="Server" ID="btnGo" Text="برو" CssClass="button" OnClick="btnGo_Click"
                Height="24px" Width="45px"  />--%>
                <asp:ImageButton runat="Server" id="ibtnGo" 
                ImageUrl="~/App_Themes/OnlineShopDefault/Images/Go.png" 
                ValidationGroup="QuickAcces" onclick="ibtnGo_Click"/>
        </td>
    	</tr>
    	
    </table>
        
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center" style="color: White; font-family: Tahoma; font-size: 9pt">
            <asp:Label runat="Server" ID="lblMessage2" Text="(مثال:03112121014)"></asp:Label>
        </td>
    </tr>
</table>
</asp:Panel>
