<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="contentplaceholderAdmin" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%" style="text-align:center; padding-top:20px;padding-bottom:20px ">
        <tr>
            <td>
            </td>
            <td>
                <table border="0" style="border-color:Black" cellspacing="0" cellpadding="0" width="100%" >
                    <tr>
                        <td style="background-color:White; height:50px; font-size:x-large; font-weight:bold; color:White;text-align:center">
                        <asp:HyperLink  id="hlshop" runat="Server"  Text="بخش فروشگاه ها" NavigateUrl="Shops.aspx"></asp:HyperLink>
                        
                        </td>
                        <td style="background-color:White; height:50px; font-size:x-large; font-weight:bold; color:White;text-align:center">
                        <asp:HyperLink runat="Server" id="hlEndUser" Text="بخش کاربر ها" NavigateUrl="EndUsers.aspx"></asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color:White; height:50px; font-size:x-large; font-weight:bold; color:White;text-align:center">
                        <asp:HyperLink runat="Server" id="hlCategory" Text="بخش دسته ها" NavigateUrl="Categories.aspx"></asp:HyperLink>
                        </td>
                        <td style="background-color:White; height:50px; font-size:x-large; font-weight:bold; color:White;text-align:center">
                        <asp:HyperLink runat="Server" id="hlProduct" Text="بخش محصولات" NavigateUrl="Products.aspx"></asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btn_click" />
</asp:Content>
