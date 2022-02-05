<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserShops.ascx.cs" Inherits="Admin_Modules_EndUserShops" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent">
    <tr>
        <td  colspan="2">
            <asp:GridView ID="gvShops" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvShops_PageIndexChanging" 
                PageSize="15" onselectedindexchanging="gvShops_SelectedIndexChanging">
                <Columns>
                    <asp:TemplateField HeaderText="فروشگاه" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl(string.Format("ShopDetails.aspx?ShopID={0}&EndUserID={1}",Eval("ShopID"),Eval("EndUserID"))) %>'
                                Text="نمايش فروشگاه"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
    <td></td>
    <td>
    
    <asp:Button id="btnAddShop" Text="افزودن فروشگاه" runat="Server" CssClass="button" onclick="btnAddShop_Click" />
    </td>
    </tr>
</table>