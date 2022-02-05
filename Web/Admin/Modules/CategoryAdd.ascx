<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CategoryAdd.ascx.cs" Inherits="Admin_Modules_CategoryAdd" %>

<%@ Register src="CategoryInfo.ascx" tagname="CategoryInfo" tagprefix="uc1" %>

<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="btnSave" runat="server" Text="ذخيره" CssClass="button" OnClick="btnSave_Click"
                            ToolTip="ذخيره ي گروه" />
                    </td>
                    <td class="title">
                        افزودن گروه
                        <img src="Icons/ico-catalog.png" alt="Category" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
             <ajaxToolkit:TabContainer runat="server" ID="CategoryTabs" ActiveTabIndex="0" CssClass="grey">
             <ajaxToolkit:TabPanel runat="server" ID="pnlCategoryInfo" HeaderText="اطلاعات گروه">
                <ContentTemplate>
                
                    <uc1:CategoryInfo ID="ctrlCategoryInfo" runat="server" />
                
                </ContentTemplate>
             </ajaxToolkit:TabPanel>
             </ajaxToolkit:TabContainer>
        </td>
    </tr>
   
</table>

