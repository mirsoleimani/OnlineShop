<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserCareerInfo.ascx.cs" Inherits="Admin_Modules_EndUserCareerInfo" %>
<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc1" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtCareer" runat="server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCareer" runat="Server" ToolTip="" Text=":شغل"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
       <tr>
        <td class="adminData">
            <asp:TextBox ID="txtCompany" runat="server" CssClass="adminInput"  />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCompany" runat="Server" ToolTip="" Text=":شرکت/فروشگاه"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtPosition" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblPosition" runat="Server" ToolTip="" Text=":سمت"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtCareerGroup" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblCareergroup" runat="Server"  Text=":گروه شغلي"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox ID="txtActivityField" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblActivityField" runat="Server"  Text=":زمينه هاي فعاليت"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
        <tr>
        <td class="adminData">
           <asp:TextBox ID="txtActivityType" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblActivityType" runat="Server"  Text=":نوع فعاليت"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
        <tr>
        <td class="adminData">
            <asp:TextBox ID="txtDeputation" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblDeputation" runat="Server"  Text=":نمايندگي"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
        <tr>
        <td class="adminData">
            <asp:RadioButton  runat="Server" id="rbtnYes" Text="بله" Checked="true" GroupName="LicenseHolder" />
            <br />
            <asp:RadioButton runat="Server" ID="rbtnNo" Text="خير" GroupName="LicenseHolder" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblLicenseHolder" runat="Server"  Text=":داراي مجوز"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
        <tr>
        <td class="adminData">
            <asp:TextBox ID="txtLicensor" runat="server" CssClass="adminInput" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblLicensor" runat="Server"  Text=":صادر کننده مجوز"></asp:Label>
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