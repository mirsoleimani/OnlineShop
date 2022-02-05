<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopDetails.ascx.cs" Inherits="Admin_Modules_ShopDetails" %>
<%@ Register Src="ShopInfo.ascx" TagName="ShopInfo" TagPrefix="uc2" %>
<%@ Register Src="ShopCategoryMap.ascx" TagName="ShopCategoryMap" TagPrefix="uc3" %>
<%@ Register src="ShopProducts.ascx" tagname="ShopProducts" tagprefix="uc1" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="SaveButton" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي فروشگاه" />
                        <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="button" OnClick="btnDelete_Click"
                            ToolTip="حذف فروشگاه" />
                    </td>
                    <td class="title">
                        <div>
                            جزييات فروشگاه
                            <img src="Icons/ico-catalog.png" alt="Category" /></div>
                        <div>
                            <asp:HyperLink CssClass="hyperLinkBack" runat="Server" ID="hlBack" Text="بازگشت به کاربر"></asp:HyperLink>
                        </div>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="shopTabs" ActiveTabIndex="1">
            <ajaxToolkit:TabPanel runat="server" ID="pnlShopProduct" HeaderText="اطلاعات محصولات">
                    <HeaderTemplate>
                        اطلاعات محصولات
                    </HeaderTemplate>
                    <ContentTemplate>
                        
                        <uc1:ShopProducts ID="ShopProducts1" runat="server" />
                        
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                  <ajaxToolkit:TabPanel runat="Server" ID="pnlShopCategoryMap" HeaderText="دسته">
                    <HeaderTemplate>
                        اطلاعات دسته
                    </HeaderTemplate>
                    <ContentTemplate>
                        <uc3:ShopCategoryMap runat="server" ID="ctrlShopCategoryMap"></uc3:ShopCategoryMap>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlShopInfo" HeaderText="اطلاعات فروشگاه">
                    <HeaderTemplate>
                        اطلاعات فروشگاه
                    </HeaderTemplate>
                    <ContentTemplate>
                        <uc2:ShopInfo ID="ctrlShopInfo" runat="server"></uc2:ShopInfo>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
              
            </ajaxToolkit:TabContainer>
        </td>
    </tr>
</table>
<ajaxToolkit:ConfirmButtonExtender ID="CBEbtnDelete" runat="server" TargetControlID="btnDelete"
    DisplayModalPopupID="MPEDelete">
</ajaxToolkit:ConfirmButtonExtender>
<ajaxToolkit:ModalPopupExtender ID="MPEDelete" runat="Server" TargetControlID="btnDelete"
    PopupControlID="pnlDelete" OkControlID="btnOkDelete" CancelControlID="btnCancelDelete">
</ajaxToolkit:ModalPopupExtender>
<asp:Panel ID="pnlDelete" runat="Server" Style="display: none; width: 250px; background-color: White;
    border-width: 2px; border-color: Black; border-style: solid; padding: 20px;">
    <table border="0" cellspacing="0" cellpadding="0" width="100%">
        <tr>
            <td class="popup">
                اطمينان داريد؟
                <div>
                    <p>
                    </p>
                    <asp:Button ID="btnOkDelete" runat="server" Text="بله" CssClass="button" CausesValidation="false" />
                    <asp:Button ID="btnCancelDelete" runat="server" Text="خير" CssClass="button" CausesValidation="false" />
                </div>
            </td>
        </tr>
    </table>
</asp:Panel>
