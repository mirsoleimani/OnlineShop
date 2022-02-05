<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserCareerAddressInfo.ascx.cs"
    Inherits="Admin_Modules_CustomerCareerAddress" %>
<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc1" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtAdd" runat="server" CssClass="adminInput"  />
            
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblAdd" runat="Server" ToolTip="" Text=":آدرس "></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtAdd2" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblAdd2" runat="Server" ToolTip="" Text=":آدرس 2"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
           <asp:TextBox ID="txtPostalCode" runat="Server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblPostalCode" runat="Server" Text=":کدپستي"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
             <asp:TextBox ID="txtCity" runat="Server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCity" runat="Server" Text=":َشهر"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
        <asp:DropDownList id="ddlStateProvince" runat="Server" AutoPostBack="false" CssClass="adminInput" ></asp:DropDownList>
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblStateProvince" runat="Server" Text=":استان"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
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
