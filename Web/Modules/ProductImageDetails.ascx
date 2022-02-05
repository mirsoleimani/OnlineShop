<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductImageDetails.ascx.cs" Inherits="Modules_ImageDetails" %>

<table border="0" cellspacing="0" cellpadding="0" width="100%">
	<tr>
		<td style="max-width:500px" align="center">
		<asp:Image runat="Server" id="imgProductImage" CssClass="ImageDetails" />
		</td>
	</tr>
	<tr>
	<td style="max-width:500px" align="center">
	<asp:Button ID="btnReturn_click" CssClass="button" runat="server" Text="بازگشت" OnClick ="return_PrePage"/>
       <%-- <input id="Button1" type="button" value="بازگشت به محصولات"onclick="window.history.go(-2)()" />--%>
	</td>
	</tr>
</table>