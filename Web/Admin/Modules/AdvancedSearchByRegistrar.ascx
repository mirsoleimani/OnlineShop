<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvancedSearchByRegistrar.ascx.cs" Inherits="Admin_Modules_AdvancedSearchShopDeputationBox" %>

<asp:Panel runat="Server"  id="pnlAdvancedSearchShopDeputation" DefaultButton="btnSearch">
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent" dir="rtl">

    <tr>
    <td class="adminTitle">
    <img src="Icons/ico-help.gif" />
            <asp:Label runat="Server" ID="lblEndUserName" Text="نام نمایندگی:"></asp:Label>
            
        </td>
        <td class="adminData">
            <asp:DropDownList runat="Server" ID="ddlEndUsers" AutoPostBack="false" CssClass="adminInput">
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
            <asp:GridView ID="gvEndUsers" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvEndUsers_PageIndexChanging" PageSize="20">
                <Columns>
                    <asp:TemplateField HeaderText="نام" ItemStyle-Width="60%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("FirstName").ToString()+" "+Eval("LastName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="40%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/EndUserDetails.aspx?EndUserID={0}",Eval("EndUserID"))) %>'
                                Text="نمايش کاربر"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
      
</table>
</asp:Panel>