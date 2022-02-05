<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductDetails.ascx.cs" Inherits="Modules_ProductDetails" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="ProductDetails">
    <tr align="center">
        <td colspan="2" class="ProductGrid">
            <asp:DataList ID="dataListProduct" runat="server" RepeatColumns="1" RepeatDirection="Horizontal"
                ItemStyle-CssClass="ItemBox" OnItemDataBound="dataListProduct_ItemDataBound">
                <ItemTemplate>
                    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ProductItem">
                        <tr>
                        
                            <td colspan="2"  class="title">
                                                   
                                    <asp:Label id="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString())%>'></asp:Label>
                           
                            </td>
                          
                        </tr>
                        <tr>
                            <td>
                                <table border="0" cellspacing="0" cellpadding="0" width="100%" class="content">
                                    <tr>
                                        <td class="picture">                                            
                                              <asp:ImageButton runat="Server"  CssClass="picture" id="ibtnImage" 
                                              ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ProductImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>'
                                              PostBackUrl='<%#Page.ResolveUrl("~/"+string.Format("ImageDetails.aspx?ImageID={0}",Eval("ImageID"))) %>' />
                                        </td>
                                        <td  class="description">
                                            <asp:Label runat="server" ID="lblDescription" Text='<%#Eval("Description").ToString()%>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr class="addInfo">
                                        <td>                                          
                                          
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
            </asp:DataList>
            <asp:Button ID="btnReturn_Click" CssClass="button" runat="server" Text="بازگشت" OnClick="return_PrePage" />
        </td>
    </tr>
</table>

