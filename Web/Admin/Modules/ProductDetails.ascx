<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductDetails.ascx.cs"
    Inherits="Admin_Modules_ProductDetails" %>
<%@ Register Src="ProductAdd.ascx" TagName="ProductAdd" TagPrefix="uc1" %>
<%@ Register src="ProductInfo.ascx" tagname="ProductInfo" tagprefix="uc2" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="SaveButton" runat="server" Text="ذخيره" CssClass="button" OnClick="SaveButton_Click"
                            ToolTip="ذخيره ي محصول" />
                        <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="button" OnClick="btnDelete_Click"
                            ToolTip="حذف محصول" />
                    </td>
                    <td class="title">
                        جزييات محصول
                        <img src="Icons/ico-catalog.png" alt="Category" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="ProductTabs" ActiveTabIndex="0">
                <ajaxToolkit:TabPanel runat="server" ID="pnlProductInfo" HeaderText="اطلاعات محصول">
                    <ContentTemplate>
                        
                        <uc2:ProductInfo ID="ctrlProductInfo" runat="server" />
                        
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
