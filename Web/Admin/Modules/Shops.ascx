<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Shops.ascx.cs" Inherits="Admin_Modules_Shops" %>
<div class="section-header">
  <div class="title">
        مديريت فروشگاه ها
        <img src="Icons/ico-catalog.png" alt="" />
    </div>
    <div class="options">
        <asp:Button runat="Server" Text="جستجو" ID="btnSearch" ToolTip="جستجوي فروشگاه" 
            CssClass="button" onclick="btnSearch_Click" />
    </div>
  
</div>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent">
    <tr>
        <td class="adminData">
            <asp:TextBox runat="Server" ID="txtShopName" Enabled="false" CssClass="adminInput" ToolTip="نام فروشگاه مورد نظر را براي جستجو وارد کنيد"></asp:TextBox>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="Label1" Text=":نام فروشگاه"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlCategoryName" AutoPostBack="false" CssClass="adminInput">
            </asp:DropDownList>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblShopName" Text=":گروه"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td colspan=2>
        <asp:GridView ID="gvShopsSearch" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvShopsSearch_PageIndexChanging" 
                PageSize="30">
                <Columns>
                    <asp:TemplateField HeaderText="فروشگاه" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" 
                            NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/ShopDetails.aspx?ShopID={0}&EndUserID={1}",Eval("ShopID"),Eval("EndUserID"))) %>'
                                Text="نمايش فروشگاه"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
        
        		  <asp:GridView ID="gvShops" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvShops_PageIndexChanging" 
                PageSize="30" onselectedindexchanging="gvShops_SelectedIndexChanging">
                <Columns>
                    <asp:TemplateField HeaderText="فروشگاه" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" 
                            NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/ShopDetails.aspx?ShopID={0}&EndUserID={1}",Eval("ShopID"),Eval("EndUserID"))) %>'
                                Text="نمايش فروشگاه"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        		
          
        </td>
    </tr>
</table>