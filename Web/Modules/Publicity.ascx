<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Publicity.ascx.cs" Inherits="Modules_PublicityShop" %>
<%@ Register Src="Pager.ascx" TagName="Pager" TagPrefix="uc1" %>

<uc1:Pager ID="ctrlTopPager" runat="server" />
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="Product">
    <tr align="center">
        <td colspan="2" class="ProductGrid">

            <asp:DataList ID="dataListProducts" runat="server"  RepeatDirection="Horizontal"
                ItemStyle-CssClass="ItemBox" 
                OnItemDataBound="dataListProducts_ItemDataBound" RepeatColumns="4">
                <ItemTemplate>
                    <table border="0" cellspacing="0" cellpadding="0" width="200%" class="ProductItem">
                        <tr>
                            <td colspan="2" class="title" align="center">
                                <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Server.HtmlEncode(Eval("Name").ToString())%>'
                                    Font-Underline="false" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("ProductDetails.aspx?ProductID={0}",Eval("ProductID"))) %>' />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table border="0" cellspacing="0" cellpadding="0" width="100%" class="content">
                                    <tr  >
                                        <td class="pictureelahe" align="center">
                                            <asp:Image runat="Server" ID="Image1" ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ProductImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>'
                                           Height="100%" Width="130px" />
                                                
                                        </td>
                                        <%--<td  class="description">
                                            <asp:Label runat="server" ID="lblDescription" Text='<%#Eval("Description").ToString()%>'></asp:Label>
                                        </td>--%>
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
                                            <asp:Label ID="lblPrice" runat="Server" CssClass="productPrice" Text='<%#String.Format("",Server.HtmlEncode(Eval("UnitPrice").ToString()))%>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>

<ItemStyle CssClass="ItemBox"></ItemStyle>
            </asp:DataList>
            
        </td>
    </tr>
    <tr>
        <%--<td>
            <asp:HyperLink ID="lnkPreviousPage" runat="server" Visible="False" Text="صفحه ي قبل" Font-Size="X-Large"></asp:HyperLink>
        </td>
        <td>
            <asp:HyperLink ID="lnkNextPage" runat="server" Visible="False" Text="صفحه ي بعد" Font-Size="X-Large"></asp:HyperLink>  
        </td>--%>
         
        
        
    </tr>
</table>
<uc1:Pager ID="ctrlBottomPager" runat="server" />