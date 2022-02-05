<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Settings.ascx.cs" Inherits="Admin_Modules_Settings" %>
<%@ Register Src="PublicityInfo.ascx" TagName="PublicityInfo" TagPrefix="uc1" %>
<%@ Register Src="GuideInfo.ascx" TagName="GuideInfo" TagPrefix="uc2" %>
<%@ Register Src="AboutUsInfo.ascx" TagName="AboutUsInfo" TagPrefix="uc3" %>
<%@ Register Src="MovingMessageInfo.ascx" TagName="MovingMessageInfo" TagPrefix="uc4" %>
<%@ Register Src="FirozehInfo.ascx" TagName="FirozehInfo" TagPrefix="uc5" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%" dir="rtl">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="title">
                        <img src="Icons/ico-configuration.png" alt="" />
                        مديريت تنظيمات سايت
                    </td>
                    <td class="options">
                        <asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي تنظيمات" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="SettingsTabs" ActiveTabIndex="0" CssClass="grey">
                <ajaxToolkit:TabPanel runat="server" ID="pnlPublicityInfo" HeaderText="اطلاعات بازاريابي">
                    <ContentTemplate>
                        <uc1:PublicityInfo ID="ctrlPublicityInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlGude" HeaderText="اطلاعات راهنما">
                    <ContentTemplate>
                        <uc2:GuideInfo ID="ctrlGuideInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlAboutUs" HeaderText="اطلاعات درباره ی ما">
                    <ContentTemplate>
                        <uc3:AboutUsInfo ID="ctrlAboutUsInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
               <%--elahe(firozeh)--%>
                <ajaxToolkit:TabPanel runat="server" ID="TabPanelFirozeh" HeaderText="دانش نامه فیروزه">
                    <ContentTemplate>
                        <uc5:FirozehInfo ID="ctrlFirozehInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>

                <ajaxToolkit:TabPanel runat="server" ID="pnlMovingMessage" HeaderText="اطلاعات پیام متحرک">
                    <ContentTemplate>
                        <uc4:MovingMessageInfo ID="ctrlMovingMessageInfo" runat="server" />
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
        </td>
    </tr>
</table>
