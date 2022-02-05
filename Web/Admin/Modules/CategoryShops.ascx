<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryShops.ascx.cs"
    Inherits="Admin_Modules_CategoryShops" %>
<table class="adminContent">
    <tr>
        <td width="100%">
            <%--<asp:UpdatePanel ID="upCategoryShops" runat="Server">
                <ContentTemplate>--%>
                    <asp:GridView ID="gvCateoryShops" runat="Server" AutoGenerateColumns="false" Width="100%"
                        AllowPaging="true" OnPageIndexChanging="gvCateoryShops_PageIndexChanging" >
                        <Columns>
                            <asp:TemplateField HeaderText="فروشگاه" ItemStyle-Width="60%">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/ShopDetails.aspx?ShopID={0}",Eval("ShopID"))) %>'
                                        Text="نمايش فروشگاه"></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                <%--</ContentTemplate>
            </asp:UpdatePanel>--%>
        </td>
    </tr>
    <tr>
        <td>
            </td>
    </tr>
</table>
