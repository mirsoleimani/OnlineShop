<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Categories.ascx.cs"
    Inherits="Admin_Modules_Categories" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button runat="Server" id="btnAdd" text="افزودن" 
                        ToolTip="افزودن گروه"  PostBackUrl="~/Admin/CategoryAdd.aspx" class="button" 
                             />
                        
                    </td>
                    <td class="title">
                        مديريت گروها
                        <img src="Icons/ico-catalog.png" alt="Category" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="section-title">
            <asp:DataList ID="dataListShopCategories" RepeatDirection="Vertical" RepeatColumns="1"
                runat="Server" Width="100%">
                <ItemTemplate>                                
                        <asp:HyperLink ID="hlShopCategory" runat="server" Font-Underline="false" Text='<%#Server.HtmlEncode(Eval("Name").ToString()) %>'
                        NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("/admin/CategoryDetails.aspx?CategoryID={0}",Eval("CategoryID"))) %>'></asp:HyperLink>                                   
                </ItemTemplate>
                <ItemStyle CssClass="section-title" />
            </asp:DataList>
        </td>
    </tr>
</table>

<p style="direction: ltr">
    &nbsp;</p>


