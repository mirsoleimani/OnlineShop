<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopAdd.ascx.cs" Inherits="Admin_Modules_ShopAdd" %>
<%@ Register Src="ShopInfo.ascx" TagName="ShopInfo" TagPrefix="uc1" %>
<%@ Register Src="ShopCategoryMap.ascx" TagName="ShopCategoryMap" TagPrefix="uc2" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي فروشگاه" />
                    </td>
                    <td class="title">
                        <div>
                            افزودن فروشگاه<img src="Icons/ico-catalog.png" alt="Category" /></div>
                        <asp:HyperLink runat="Server" ID="hlReturn" Text="بازگشت به کاربر"></asp:HyperLink>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="ShopTabs" ActiveTabIndex="0">
               
                <ajaxToolkit:TabPanel runat="server" ID="pnlShopInfo" HeaderText="اطلاعات فروشگاه">
                    <ContentTemplate>
                        <uc1:ShopInfo ID="ctrlShopInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
        </td>
    </tr>
</table>
