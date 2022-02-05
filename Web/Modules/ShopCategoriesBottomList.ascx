<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopCategoriesBottomList.ascx.cs" Inherits="Modules_ShopCategoriesBottomList" %>

<asp:Repeater runat="Server" id="rptShopCategories"  >
<ItemTemplate>
 
		<asp:HyperLink ID="HyperLink1" runat="server" 
		NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("Shops.aspx?CategoryID={0}",Eval("CategoryID"))) %>'
        Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>' Font-Underline="false"></asp:HyperLink>

		|

</ItemTemplate>
</asp:Repeater>
