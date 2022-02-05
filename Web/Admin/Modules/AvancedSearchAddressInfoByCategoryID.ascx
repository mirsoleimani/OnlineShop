<%@ Control Language="C#" AutoEventWireup="true"
 CodeFile="AvancedSearchAddressInfoByCategoryID.ascx.cs" 
 Inherits="Admin_Modules_AvancedSearchAddressInfoByCategoryID" %>
<asp:Panel runat="Server"  id="pnlAdvancedSearchShopDeputation" DefaultButton="btnSearch">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent" dir="rtl">

    <tr>
    <td class="adminTitle">
    <img src="Icons/ico-help.gif" />
            <asp:Label runat="Server" ID="lblEndUserName" Text="نام گروه:"></asp:Label>
            
        </td>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlCategoryName" AutoPostBack="false" CssClass="adminInput">
            </asp:DropDownList>
        </td>
        
    </tr>
    <tr>
        <td class="adminTitle" >
        </td>
        <td class="adminData" >
            <asp:Button runat="Server" Text="جستجو" ID="btnSearch" ToolTip="جستجو" 
            CssClass="button" onclick="btnSearch_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="gvAddressInfo" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvAddressInfo_PageIndexChanging" PageSize="30">
                <Columns>
                    <asp:TemplateField HeaderText="نام فروشگاه" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="استان" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblStateProvinceName" runat="Server" Text='<%#Server.HtmlEncode(Eval("StateProvinceName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="شهر" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblCity" runat="Server" Text='<%#Server.HtmlEncode(Eval("City").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="آدرس" ItemStyle-Width="40%">
                        <ItemTemplate>
                            <asp:Label ID="lblAddress" runat="Server" Text='<%#Server.HtmlEncode(Eval("Address1").ToString()+" "+Eval("Address2").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="کد پستی" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblPostalCode" runat="Server" Text='<%#Server.HtmlEncode(Eval("PostalCode").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="10%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/ShopDetails.aspx?ShopID={0}",Eval("ShopID"))) %>'
                                Text="نمايش فروشگاه"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
      
</table>
</asp:Panel>