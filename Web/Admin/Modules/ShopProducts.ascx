<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopProducts.ascx.cs" Inherits="Admin_Modules_ShopProducts" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent">
    <tr>
        <td  colspan="2">
            <asp:GridView ID="gvProducts" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvProducts_PageIndexChanging" 
                PageSize="15" >
                <Columns>
                    <asp:TemplateField HeaderText="محصول" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl(string.Format("~/Admin/ProductDetails.aspx?ProductID={0}&ShopID={1}",Eval("ProductID"),Eval("ShopID"))) %>'
                                Text="نمايش محصول"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
    <td></td>
    <td>
    
    <asp:Button id="btnAddProduct" Text="افزودن محصول" runat="Server" CssClass="button" 
            onclick="btnAddProduct_Click" />
    </td>
    </tr>
</table>