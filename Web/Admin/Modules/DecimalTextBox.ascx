<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DecimalTextBox.ascx.cs" Inherits="Admin_Modules_DecimalTextBox" %>
 
<asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
<ajaxToolkit:FilteredTextBoxExtender ID="ftbeValue" runat="server" TargetControlID="txtValue"
    FilterType="Custom, Numbers" ValidChars=".-" />
<asp:RequiredFieldValidator ID="rfvValue" ControlToValidate="txtValue" Font-Name="Arial"
    Font-Size="small" runat="server" Display="None"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="rvValue" runat="server" ControlToValidate="txtValue" Type="Double"
    Display="None"></asp:RangeValidator>
<ajaxToolkit:ValidatorCalloutExtender runat="Server" ID="rfvValueE" TargetControlID="rfvValue"
    HighlightCssClass="validatorCalloutHighlight" Width="150px" />
<ajaxToolkit:ValidatorCalloutExtender runat="Server" ID="rvValueE" TargetControlID="rvValue"
    HighlightCssClass="validatorCalloutHighlight" Width="150px"/>
