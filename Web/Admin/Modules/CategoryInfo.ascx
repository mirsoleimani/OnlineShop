<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryInfo.ascx.cs"
    Inherits="Admin_Modules_CategoryInfo" %>

<%@ Register src="SimpleTextBox.ascx" tagname="SimpleTextBox" tagprefix="uc1" %>

<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
           
            <uc1:SimpleTextBox ID="stxtName" runat="server" CssClass="adminInput" ErrorMessage="نام گروه را وارد کنيد" />
           
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCategoryName" runat="Server" ToolTip="نام گروه" Text=":نام"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:FileUpload ID="fuCategoryImage" CssClass="adminInput" runat="server" ToolTip="تصوير دسته را براي بارگزاري انتخاب کنيد" />
            <br />
            <asp:Image ID="iCategoryImage" runat="server" Width="250px" />
            <br />
            <asp:Button ID="btnRemoveCategoryImage" CssClass="button" CausesValidation="false"
                runat="server" Text="حذف تصوير" OnClick="btnRemoveCategoryImage_Click" Visible="false"
                ToolTip="حذف تصوير" />
            <br />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCategoryImage" runat="Server" ToolTip="تصوير گروه" Text=":تصوير"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        
        <td class="adminData">
       
            <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" AutoDetectLanguage="false"
                Height="350" Width="800px" 
                BasePath="~/Editors/fckeditor/">
            </FCKeditorV2:FCKeditor>
        </td>
        <td class="adminTitle">
        <asp:Label runat="Server" ID="lblCategoryDescription" Text="توضيحات" ToolTip="توضيحات گروه"></asp:Label>
        <img src="Icons/ico-help.gif" alt="">
           
        </td>
    </tr>
    
</table>
