<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopInfo.ascx.cs" Inherits="Admin_Modules_ShopInfo" %>
<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc2" %>
<%@ Register Src="PersianCalendar.ascx" TagName="PersianCalendar" TagPrefix="uc1" %>
<%@ Register Src="ShopRating.ascx" TagName="ShopRating" TagPrefix="uc3" %>

<%@ Register src="NumericTextBox.ascx" tagname="NumericTextBox" tagprefix="uc4" %>

<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
            <uc2:SimpleTextBox ID="stxtName" runat="server" CssClass="adminInput" ErrorMessage="نام فروشگاه را وارد کنيد" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblShopName" runat="Server" ToolTip="نام فروشگاه" Text=":نام"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:FileUpload ID="fuShopImage"  CssClass="adminInput" runat="server" ToolTip="تصوير فروشگاه را براي بارگزاري انتخاب کنيد" />
            <br />
            <asp:Image ID="iShopImage" Width="250px" runat="server" />
            <br />
            <asp:Button ID="btnRemoveShopImage" CssClass="button" CausesValidation="false" runat="server"
                Text="حذف تصوير" OnClick="btnRemoveShopImage_Click" Visible="false" ToolTip="حذف تصوير" />
            <br />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblShopImage" runat="Server" ToolTip="تصوير فروشگاه" Text=":تصوير"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
      
            <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" AutoDetectLanguage="false"
                Height="350" Width="800px" BasePath="~/Editors/fckeditor/" ToolbarSet="Basic">
            </FCKeditorV2:FCKeditor>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblShopDescription" Text=":توضيحات" ToolTip="توضيحات فروشگاه"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
    </tr>

    <tr>
        <td class="adminData">
    
           <uc2:SimpleTextBox ID="stxtCode" runat="Server" CssClass="adminInput" ErrorMessage="کد فروشگاه را وارد کنيد" />
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblCode" Text=":کد" ToolTip="کد دسترسي سريع"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
    </tr>
    <tr>
    <td class="adminData">
    
        <uc3:ShopRating ID="ctrlShopRating" runat="server"   />
    
    </td>
    <td class="adminTitle">
    <asp:Label runat="Server" ID="LblRating" Text=":امتياز" ToolTip="امتياز فروشگاه"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
    </td>
    </tr>
</table>
