<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Pager.ascx.cs" Inherits="Modules_Pager" %>
<p dir="rtl" style="background-color:White; font-size:medium; text-align:center">
    صفحه ي
    <asp:Label ID="currentPageLabel" runat="server" />
    از
    <asp:Label ID="howManyPagesLabel" runat="server" />
    |
    <asp:HyperLink ID="previousLink" runat="server" Font-Size="Medium">قبلي</asp:HyperLink>
    <asp:Repeater ID="pagesRepeater" runat="server">
        <ItemTemplate>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("Gallery.aspx?ShopID={0}&PageNumber={1}",Eval("ShopID"),Eval("PageNumber"))) %>'
        Text='<%# Eval("PageNumber") %>' />
        </ItemTemplate>
    </asp:Repeater>
    <asp:HyperLink ID="nextLink" runat="server" Font-Size="Medium">بعدي</asp:HyperLink>
</p>
