<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopDetails.ascx.cs" Inherits="Modules_ShopDetails" %>
<%@ Register Src="../Admin/Modules/ShopRating.ascx" TagName="ShopRating" TagPrefix="uc1" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="ShopDetail">
    <tr>
        <td style="text-align: -moz-center">
            <asp:DataList ID="dataListShop" runat="server" ItemStyle-CssClass="ItemBox" OnItemDataBound="dataListShop_ItemDataBound">
                <ItemTemplate>
                    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="ShopItem">
                        <tr>
                            <td class="title">
                                <%#Eval("Name") %>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                    <tr>
                                        <td class="image">
                                            <asp:Image runat="Server" ID="iShop" Width="250px" Height="250px" ImageUrl='<%#Page.ResolveUrl("~/"+string.Format("ShopImageViewer.ashx?ImageID={0}",Eval("ImageID"))) %>' />
                                        </td>
                                        <td class="description">
                                            <%#Eval("Description")%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="ContactInfo">
                                            <asp:Repeater runat="Server" ID="rptrContactInfo">
                                                <ItemTemplate>
                                                    <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="Literal1" Text="تلفن:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("Phone").ToString()) %>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="Literal3" Text="فاکس:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("Fax").ToString()) %>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="Literal4" Text="ايميل:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("Email").ToString()) %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </td>
                                        <td class="AddInfo">
                                            <asp:Repeater runat="Server" ID="rptrAddressInfo">
                                                <ItemTemplate>
                                                    <table border="0" cellspacing="0" cellpadding="0" width="100%">
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="litCity" Text="شهر:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("City").ToString()) %>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="Literal1" Text="آدرس:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("Address1").ToString()+" "+Eval("Address2").ToString()) %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </td>
                                        
                                    </tr>
                                   <tr>
                                   <td></td>
                                   <td class="AddInfo">
                                            <asp:Repeater ID="rptrCareerInfo" runat="server">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:Literal runat="Server" ID="Literal2" Text="زمینه فعالیت:"></asp:Literal>
                                                            </td>
                                                            <td>
                                                                <%#Server.HtmlEncode(Eval("ActivityField").ToString()) %>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </td>
                                   </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>
