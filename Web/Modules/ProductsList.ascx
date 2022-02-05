<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductsList.ascx.cs"
    Inherits="Modules_ProductsList" %>
    
<%@ Register src="Pager.ascx" tagname="Pager" tagprefix="uc1" %>
    <uc1:Pager ID="ctrlTopPager" runat="server" />  
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="Product">
    <tr>
        <td colspan="2" class="ProductGrid">
          
            <asp:DataList ID="dataListProducts" runat="server" RepeatColumns="2" RepeatDirection="Horizontal"
                ItemStyle-CssClass="ItemBox" OnItemDataBound="dataListProducts_ItemDataBound">
                <ItemTemplate>
                    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ProductItem">
                        <tr>
                            <td colspan="2" class="title">
                                <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Server.HtmlEncode(Eval("Name").ToString())%>'
                                    Font-Underline="false" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("ProductDetails.aspx?ProductID={0}",Eval("ProductID"))) %>' />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table border="0" cellspacing="0" cellpadding="0" width="100%" class="content">
                                    <tr>
                                        <td class="picture">
                                            <asp:Image runat="Server" ID="Image1" ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ProductImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>'
                                                Width="100px" Height="100px" />
                                        </td>
                                        <td  class="description">
                                       <%-- <asp:HyperLink runat="Server" id="hlShop" --%>
                                            <asp:Label runat="server" ID="lblDescription" Text='<%#Eval("Description").ToString()%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr class="addInfo">
                                        <td>                                          
                                            <asp:Button runat="server" ID="btnDetails" Text="جزييات" ValidationGroup="ProductDetails"
                                                CommandArgument='<%#Eval("ProductID") %>' OnCommand="btnDetails_Click" CssClass="button" />
                                            <br />
                                            <asp:Button runat="server" ID="btnAdd" Text="خريد" ValidationGroup="ProductDetails"
                                                CommandArgument='<%#Eval("ProductID") %>'  CssClass="button" />
                                        </td>
                                        <td class="prices">
                                            <asp:Label ID="lblPrice" runat="Server" CssClass="productPrice" Text='<%#String.Format("ريال {0}",Server.HtmlEncode(Eval("UnitPrice").ToString()))%>'></asp:Label>
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
<%--    <tr>
        <td>
            <asp:HyperLink ID="lnkPreviousPage" runat="server" Visible="False" Text="صفحه ي قبل"></asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="lnkNextPage" runat="server" Visible="False" Text="صفحه ي بعد"></asp:HyperLink>
        </td>
    </tr>--%>
</table>
    <uc1:Pager ID="ctrlBottomPager" runat="server" />  
