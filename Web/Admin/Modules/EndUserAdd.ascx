<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserAdd.ascx.cs" Inherits="Admin_Modules_CustomerAdd" %>

<%@ Register src="EndUserRegisterInfo.ascx" tagname="EndUserRegisterInfo" tagprefix="uc6" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <%--<asp:Button ID="SaveButton" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي کاربر " />--%>
                    </td>
                    <td class="title">
                        افزودن کاربر
                        <img src="Icons/ico-EndUsers.png" alt="" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <ajaxToolkit:TabContainer runat="server" ID="EndUserTabs" >

                <ajaxToolkit:TabPanel runat="server" ID="pnlEndUserInfo" HeaderText="اطلاعات کاربر" TabIndex="1">
                    <ContentTemplate>
                        
                        <uc6:EndUserRegisterInfo ID="ctrlEndUserRegisterInfo" runat="server" />
                        
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
        </td>
    </tr>
    </table>


