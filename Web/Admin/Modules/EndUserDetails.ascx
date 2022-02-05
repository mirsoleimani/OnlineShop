<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserDetails.ascx.cs"
    Inherits="Admin_Modules_EndUserDetails" %>
<%@ Register Src="EndUsePersonalInfo.ascx" TagName="EndUsePersonalInfo" TagPrefix="uc1" %>
<%@ Register Src="EndUserCareerInfo.ascx" TagName="EndUserCareerInfo" TagPrefix="uc2" %>
<%@ Register Src="EndUserContactInfo.ascx" TagName="EndUserContactInfo" TagPrefix="uc3" %>
<%@ Register Src="EndUserHomeAddressInfo.ascx" TagName="EndUserHomeAddressInfo" TagPrefix="uc4" %>
<%@ Register Src="EndUserCareerAddressInfo.ascx" TagName="EndUserCareerAddressInfo"
    TagPrefix="uc5" %>
<%@ Register src="EndUserShops.ascx" tagname="EndUserShops" tagprefix="uc6" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <%--<asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي کاربر" />--%>
                        <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="button" OnClick="btnDelete_Click"
                            ToolTip="حذف کلي کاربر" />
                    </td>
                    <td class="title">
                        جزييات کاربر
                        <img src="Icons/ico-endusers.png" alt="EndUser" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="EndUserTabs" ActiveTabIndex="5">
             <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserShops" HeaderText="فروشگاه ها">
                    <ContentTemplate>
                       <uc6:EndUserShops ID="ctrlEndUserShops" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserHomeAddressInfo" HeaderText="ادرس مسکوني">
                    <ContentTemplate>
                        <uc4:EndUserHomeAddressInfo ID="ctrlEndUserHomeAddressInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserCareerAddressInfo" HeaderText="ادرس شغلي">
                    <ContentTemplate>
                        <uc5:EndUserCareerAddressInfo ID="ctrlEndUserCareerAddressInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserContactInfo" HeaderText="اطلاعات تماس">
                    <ContentTemplate>
                        <uc3:EndUserContactInfo ID="ctrlEndUserContactInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserCareerInfo" HeaderText="اطلاعات شغلي">
                    <ContentTemplate>
                        <uc2:EndUserCareerInfo ID="ctrlEndUserCareerInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserPersonalInfo" HeaderText="اطلاعات شخصي">
                    <ContentTemplate>
                        <uc1:EndUsePersonalInfo ID="ctrlEndUsePersonalInfo" runat="server"></uc1:EndUsePersonalInfo>
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
