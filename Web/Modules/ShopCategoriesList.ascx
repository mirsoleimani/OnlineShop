<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopCategoriesList.ascx.cs"
    Inherits="Modules_ShopCategories" %>
    <script type="text/javascript">
var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
</script>
<script type="text/javascript">
try {
var pageTracker = _gat._getTracker("UA-11817401-1");
pageTracker._trackPageview();
} catch(err) {}</script>
<table border="0" cellspacing="0" cellpadding="0" class="HomePageCategoryGrid">
    <tr>
        <td align="center">
            <asp:DataList ID="dataListShopCategories" RepeatColumns="3" RepeatDirection="Horizontal"
                RepeatLayout="Table" runat="server" ItemStyle-CssClass="ItemBox">
                <ItemTemplate>
                    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="HomePageCategoryItem">
                        <tr>
                            <td class="image" align="right">
                                <%--<asp:Image runat="Server" ID="Image1" BorderStyle="Solid" BorderWidth="1" 
                                BorderColor="Silver" Width="100px" 
                                ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ShopCategoryImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>' 
                                />--%>
                                <asp:ImageButton runat="Server" id="ibtnCategoryImage"  BorderStyle="Solid" BorderWidth="1" 
                                BorderColor="Silver" Width="100px" PostBackUrl='<%#Page.ResolveUrl("~/"+string.Format("Shops.aspx?CategoryID={0}",Eval("CategoryID"))) %>'
                                ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ShopCategoryImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>' />
                            </td>
                            <td style="vertical-align: text-top; text-align: center" align="center">
                                <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                    <tr>
                                        <td class="title">
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("Shops.aspx?CategoryID={0}",Eval("CategoryID"))) %>'
                                                Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>' Font-Underline="false"></asp:HyperLink>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="description">
                                            <asp:Literal runat="Server" ID="litDescription" Text='<%#Eval("Description").ToString() %>'></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>
