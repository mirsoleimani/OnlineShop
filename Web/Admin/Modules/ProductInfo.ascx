<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductInfo.ascx.cs" Inherits="Admin_Modules_ProductInfo" %>
<%@ Register src="DecimalTextBox.ascx" tagname="DecimalTextBox" tagprefix="uc1" %>
<%@ Register src="SimpleTextBox.ascx" tagname="SimpleTextBox" tagprefix="uc2" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
            
            <uc2:SimpleTextBox ID="stxtName" runat="server"  CssClass="adminInput" ErrorMessage="نام محصول را وارد کنيد"/>
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblProductName" runat="Server" ToolTip="نام محصول" Text=":نام"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:FileUpload ID="fuProductImage" CssClass="adminInput" runat="server" ToolTip="تصوير محصول را براي بارگزاري انتخاب کنيد" />
            <br />
            <asp:Image ID="iProductPicture" Width="250px" runat="server" />
            <br />
            <asp:Button ID="btnRemoveProductImage" CssClass="button" CausesValidation="false"
                runat="server" Text="حذف تصوير" OnClick="btnRemoveProductImage_Click" Visible="false"
                ToolTip="حذف تصوير" />
            <br />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblProductImage" runat="Server" ToolTip="تصوير محصول" Text=":تصوير"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" AutoDetectLanguage="false"
                Height="350" Width="800px" BasePath="~/Editors/fckeditor/">
            </FCKeditorV2:FCKeditor>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblProductDescription" Text="توضيحات" ToolTip="توضيحات محصول"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlShops" AutoPostBack="false" CssClass="adminInput">
            </asp:DropDownList>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblProductShop" Text=":فروشگاه" ToolTip="فروشگاه محصول"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
    </tr>
    <tr>
    <td class="adminData">
    
        <uc1:DecimalTextBox ID="txtProductPrice" runat="server" CssClass="adminInput"
        Value=0 RequiredErrorMessage="قيمت محصول را وارد کنيد" MinimumValue="0"
        MaximumValue="999999999" RangeErrorMessage="قيمت بايد بين 0 تا 999999999 باشد"/>
    
    </td>
    <td class="adminTitle">
    <asp:Label runat="Server" ID="lblProductPrice" Text=":قيمت" ToolTip="قيمت محصول"></asp:Label>
    <img src="Icons/ico-help.gif" alt="">
    </td>
    </tr>
    <tr>
    <td class="adminData">
    <asp:CheckBox ID="cbEnableBuyButton" runat="Server" Checked="false" />
    </td>
    <td class="adminTitle" >
    <asp:Label runat="Server" ID="lbEnableBuyButton" Text=":امکان خريد" ToolTip="نمايش دکمه ي خريد براي محصول"></asp:Label>
    <img src="Icons/ico-help.gif" alt="">
    </td>
    </tr>
</table>
