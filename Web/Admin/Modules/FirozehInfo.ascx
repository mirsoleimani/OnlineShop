<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FirozehInfo.ascx.cs" Inherits="Admin_Modules_FirozehInfo" %>

<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%"
    dir="rtl" >
    <tr>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblGuideDescription" Text="توضيحات" ToolTip="توضيحات دانشنامه فیروزه"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
        <td class="adminData">
            <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" AutoDetectLanguage="false"
                Height="350" Width="800px" BasePath="~/Editors/fckeditor/">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>
  <%--  <tr>
        <td class="adminTitle">
            <asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                ToolTip="ذخيره ي اطلاعات" />
        </td>
        <td>
        </td>
    </tr>--%>
</table>
