<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopsList.ascx.cs" Inherits="Modules_Shops" %>

<%@ Register src="Pager.ascx" tagname="Pager" tagprefix="uc1" %>
<%@ Register src="../Admin/Modules/ShopRating.ascx" tagname="ShopRating" tagprefix="uc2" %>
<uc1:Pager ID="ctrlTopPager" runat="server" Visible="false" />
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td align="center">
            <div class="ShopGrid">
                <asp:DataList ID="dataListShops" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                    ItemStyle-CssClass="ItemBox" onitemdatabound="dataListShops_ItemDataBound">
                    <ItemTemplate>
                        <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ShopItem">
                            <tr>
                                <td class="title">
                                    <asp:HyperLink ID="HyperLink1" runat="server" Width="100%" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("Shop.aspx?ShopID={0}&EndUserID={1}",Eval("ShopID"),Eval("EndUserID"))) %>'
                                        Text='<%#Server.HtmlEncode(Eval("Name").ToString())%>'
                                        ToolTip='<%#Server.HtmlEncode(Eval("Name").ToString())%>' Font-Underline="false"></asp:HyperLink>
                                </td>
                            </tr>
                            <tr>
                                <td class="description">
                              
                                <asp:Label runat="Server" id="lblDescription" text='<%#Eval("Description")%>'></asp:Label>
                                
                                    <%--<asp:Image runat="Server" ID="Image1" Width="145px" Height="110px" ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ShopImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>' />--%>
                                </td>
                            </tr>
                         
                            
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </td>
    </tr>
    <tr>
    <td class="Message">
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </td>
    </tr>
</table>
<uc1:Pager ID="ctrlBottomPager" runat="server" Visible="false" />





