<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUsePersonalInfo.ascx.cs"
    Inherits="Admin_Modules_CustomerInfo" %>
<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc1" %>
<%@ Register Src="PersianCalendar.ascx" TagName="PersianCalendar" TagPrefix="uc2" %>
<%@ Register Src="EmailTextBox.ascx" TagName="EmailTextBox" TagPrefix="uc3" %>
<table class="adminContent" border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td class="adminData">
            <uc1:SimpleTextBox ID="stxtName" runat="server" CssClass="adminInput" ErrorMessage="نام  را وارد کنيد" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblName" runat="Server" ToolTip="نام مشتري" Text=":نام"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <uc1:SimpleTextBox ID="stxtFamily" runat="server" CssClass="adminInput" ErrorMessage="نام فاميل  را وارد کنيد" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="Label1Family" runat="Server" ToolTip="فاميل مشتري" Text=":فاميل"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <uc1:SimpleTextBox ID="stxtFatherName" runat="server" CssClass="adminInput" ErrorMessage="نام پدر را وارد کنيد" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblFatherName" runat="Server" Text=":نام پدر"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <uc2:PersianCalendar ID="ctrlPersianCalendar" runat="server" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblBirthDate" runat="Server" Text=":تاريخ تولد"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:RadioButton ID="rbtnMale" runat="Server" Text="مرد" GroupName="Gender" Checked="true" />
            <br />
            <asp:RadioButton ID="rbtnFemale" runat="Server" Text="زن" GroupName="Gender" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblGender" runat="Server" Text=":جنسيت"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:RadioButton ID="rbtnMarried" runat="Server" Text="متاهل" GroupName="Marital"
                Checked="true" />
            <br />
            <asp:RadioButton ID="rbtnSingle" runat="Server" Text="مجرد" GroupName="Marital" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblMaritalStatus" runat="Server" Text=":تاهل"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:RadioButton ID="rbtn100" runat="Server" Text="100-300" GroupName="Income" />
            &nbsp
            <asp:RadioButton ID="rbtn300" runat="Server" Text="300-500" GroupName="Income" />
            <br />
            <asp:RadioButton ID="rbtn500" runat="Server" Text="500-700" GroupName="Income" />
            &nbsp
            <asp:RadioButton ID="rbtn700" runat="Server" Text="700به بالا" GroupName="Income" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblIncome" runat="Server" Text=":درآمد"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:RadioButton ID="rbtn4th" runat="Server" Text="زير ديپلم" GroupName="Graduation" />
            <br />
            <asp:RadioButton ID="rbtn3rd" runat="Server" Text="ديپلم" GroupName="Graduation" />
            <br />
            <asp:RadioButton ID="rbtn2ed" runat="Server" Text="کارشناسي" GroupName="Graduation" />
            <br />
            <asp:RadioButton ID="rbtn1st" runat="Server" Text="کارشناسي ارشد و دکترا" GroupName="Graduation" />
        </td>
        <td class="adminTitle">
            <asp:Label ID="lblEducation" runat="Server" Text=":تحصيلات"></asp:Label>
            <img src="Icons/ico-help.gif" alt="" />
        </td>
    </tr>
    <p>
    </p>

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
