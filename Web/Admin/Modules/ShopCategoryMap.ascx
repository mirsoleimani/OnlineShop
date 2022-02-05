<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopCategoryMap.ascx.cs"
    Inherits="Admin_Modules_ShopCategoryMap" %>
<table class="adminContent">
    <tr>
        <td width="100%" dir="rtl">
            <asp:GridView ID="gvShopCategoryMap" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvShopcategoryMap_PageIndexChanging" PageSize="30">
                <Columns>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl(string.Format("CategoryDetails.aspx?CategoryID={0}",Eval("CategoryID"))) %>'
                                Text="نمايش دسته"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="دسته" ItemStyle-Width="60%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <span style="float: right">
                                <asp:CheckBox runat="Server" ID="cbShopCategoryMap" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'
                                    Checked='<%#Eval("IsMapped") %>' /></span>
                            <asp:HiddenField runat="Server" ID="hfCategoryID" Value='<%# Eval("CategoryID") %>' />
                            <asp:HiddenField runat="Server" ID="hfShopCategoryID" Value='<%# Eval("ShopCategoryID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>
        </td>
    </tr>
</table>
