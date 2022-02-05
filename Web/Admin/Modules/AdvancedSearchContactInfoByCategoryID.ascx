<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvancedSearchContactInfoByCategoryID.ascx.cs" Inherits="Admin_Modules_AdvancedSearchContactInfoByCategoryID" %>
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
            <asp:GridView ID="gvContactInfo" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvContactInfo_PageIndexChanging" PageSize="30">
                <Columns>
                    <asp:TemplateField HeaderText="نام فروشگاه" ItemStyle-Width="20%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="کدشهر" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblAreaCode" runat="Server" Text='<%#Server.HtmlEncode(Eval("AreaCode").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="تلفن" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblPhone" runat="Server" Text='<%#Server.HtmlEncode(Eval("Phone").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="همراه" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblCellPhone" runat="Server" Text='<%#Server.HtmlEncode(Eval("CellPhone").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="فاکس" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblFax" runat="Server" Text='<%#Server.HtmlEncode(Eval("Fax").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                      <asp:TemplateField HeaderText="ایمیل" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="Server" Text='<%#Server.HtmlEncode(Eval("Email").ToString()) %>'></asp:Label>
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