<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryDetails.ascx.cs"
    Inherits="Admin_Modules_CategoryDetails" %>
<%@ Register Src="CategoryInfo.ascx" TagName="CategoryInfo" TagPrefix="uc1" %>
<%@ Register Src="CategoryShops.ascx" TagName="CategoryShops" TagPrefix="uc1" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="SaveButton" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي گروه" />
                        <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="button" OnClick="btnDelete_Click"
                            ToolTip="حذف گروه" />
                    </td>
                    <td class="title">
                        جزييات گروه
                        <img src="Icons/ico-catalog.png" alt="Category" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="CategoryTabs" ActiveTabIndex="1" >
                <ajaxToolkit:TabPanel runat="server" ID="pnlCategoryShops" HeaderText="فروشگاهها">
                    <ContentTemplate>
                        <uc1:CategoryShops ID="ctrlCategoryShops" runat="server" >
                            
                            
                        </uc1:CategoryShops>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlCategoryInfo" HeaderText="اطلاعات گروه">
                    <ContentTemplate>
                        <uc1:CategoryInfo ID="ctrlCategoryInfo" runat="server" />
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
