<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuickGuide.ascx.cs" Inherits="Modules_QuickGuide" %>
<table style="border: solid 0px White; text-align:center; margin-right:5px; height:80px; background-image: url('~/App_Themes/OnlineShopDefault/Images/PhisycalLogo.jpg')" cellspacing="0"
    cellpadding="0" width="120px" dir="rtl">
    <tr>
        <td colspan="2" style=" color:White; font-family:Tahoma; font-size:9pt;padding:0 5px 0 5px;">
        <asp:Image runat="Server" id="iLogo" Width="50px"  ImageUrl="~/App_Themes/OnlineShopDefault/Images/PhisycalLogo.png" />
        </td>
        

        <td colspan="2" style=" color:White; font-family:Tahoma; font-size:9pt; text-align:justify; ">

            <asp:Label runat="Server" ID="lblMessage" 
            Text=""></asp:Label>
        
        </td>
    </tr>
</table>