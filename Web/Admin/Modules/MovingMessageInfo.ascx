<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MovingMessageInfo.ascx.cs" Inherits="Admin_Modules_MovingMessageInfo" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%"
    dir="rtl" >
    <tr>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblGuideDescription" Text="توضيحات" ToolTip="توضيحات پیام"></asp:Label>
            <img src="Icons/ico-help.gif" alt="">
        </td>
        <td class="adminData">
            <FCKeditorV2:FCKeditor ID="txtDescription" runat="server" AutoDetectLanguage="false"
                Height="350" Width="800px" BasePath="~/Editors/fckeditor/">
            </FCKeditorV2:FCKeditor>
        </td>
    </tr>

</table>