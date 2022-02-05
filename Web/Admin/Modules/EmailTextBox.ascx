<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmailTextBox.ascx.cs" Inherits="Admin_Modules_EmailTextBox" %>

<asp:TextBox ID="txtValue" runat="server" ></asp:TextBox>
<%--<asp:RequiredFieldValidator ID="rfvValue" runat="server" ControlToValidate="txtValue"
   ErrorMessage="ادرس ايميل را وارد کنيد"  Display="None" />--%>
<asp:RegularExpressionValidator ID="revValue" runat="server" ControlToValidate="txtValue"
    ValidationExpression=".+@.+\..+" ErrorMessage="ادرس ايمل وارد شده معتبر نمي باشد" Display="None" />
<%--<ajaxToolkit:ValidatorCalloutExtender runat="Server" ID="rfvValueE" TargetControlID="rfvValue"
    HighlightCssClass="validatorCalloutHighlight" Width="150px" />--%>
<ajaxToolkit:ValidatorCalloutExtender runat="Server" ID="revValueE" TargetControlID="revValue"
    HighlightCssClass="validatorCalloutHighlight" Width="150px"/>