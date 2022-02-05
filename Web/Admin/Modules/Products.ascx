<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Products.ascx.cs" Inherits="Admin_Modules_Products" %>
<div class="section-header">
  <div class="title">
        مديريت محصولات
        <img src="Icons/ico-catalog.png" alt="" />
    </div>
    <div class="options">
        <asp:Button runat="Server" Text="جستجو" ID="btnSearch" ToolTip="جستجوي محصول" 
            CssClass="button" onclick="btnSearch_Click" />
       <%-- <input type="button" onclick="location.href='ProductAdd.aspx'" value="افزودن" id="btnAdd"
                            class="button" title="افزودن محصول " />
         --%>
    </div>
  
</div>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent">
    <tr>
        <td class="adminData">
            <asp:TextBox runat="Server" ID="txtProductName" Enabled="false" CssClass="adminInput" ToolTip="نام محصول مورد نظر را براي جستجو وارد کنيد"></asp:TextBox>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="Label1" Text=":نام محصول"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlShops" AutoPostBack="false" CssClass="adminInput">
            </asp:DropDownList>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblShopName" Text=":نام فروشگاه"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="gvProducts" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvProducts_PageIndexChanging" PageSize="15">
                <Columns>
                    <asp:TemplateField HeaderText="محصول" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/ProductDetails.aspx?ProductID={0}&ShopID={1}",Eval("ProductID"),Eval("ShopID"))) %>'
                                Text="نمايش محصول"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
