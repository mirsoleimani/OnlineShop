<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserContactInfo.ascx.cs" Inherits="Admin_Modules_CustomerContactInfo" %>

<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc1" %>
<%@ Register src="PersianCalendar.ascx" tagname="PersianCalendar" tagprefix="uc2" %>
<%@ Register src="EmailTextBox.ascx" tagname="EmailTextBox" tagprefix="uc3" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
<tr>
        <td class="adminData">
            <asp:TextBox  ID="txtAreaCode" runat="server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblAreaCode" runat="Server" ToolTip="" Text=":کدشهر"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox  ID="txtPhone" runat="server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblPhone" runat="Server" ToolTip="" Text=":تلفن ثابت"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtCellPhone" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCellPhone" runat="Server" ToolTip="" Text=":تلفن همراه"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtFax" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblFax" runat="Server"  Text=":دورنگار"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
  <tr>
        <td class="adminData">
            
            <uc3:EmailTextBox ID="etxtEmail" runat="server" CssClass="adminInput"/>
            
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblEmail" runat="Server"  Text=":ايميل" ></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
       </tr>
        <tr>
        <td>
        </td>
        <td class="adminTitle">
            <%--<asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="button" OnClick="btnDelete_Click"
                ToolTip="حذف اطلاعات" />--%>
            <asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                ToolTip="ذخيره ي اطلاعات" />
        </td>
    </tr>
     </table>
