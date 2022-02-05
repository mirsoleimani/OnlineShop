<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductAdd.ascx.cs" Inherits="Admin_Modules_ProductAdd" %>
<%@ Register src="ProductInfo.ascx" tagname="ProductInfo" tagprefix="uc1" %>
<table border="0" cellspacing="0" cellpadding="0" width="100%">
    <tr>
        <td>
            <table border="0" cellspacing="0" cellpadding="0" width="100%" class="section-header">
                <tr>
                    <td class="options">
                        <asp:Button ID="SaveButton" runat="server" Text="ذخيره" CssClass="button" OnClick="SaveButton_Click"
                            ToolTip="ذخيره ي محصول" />
                    </td>
                    <td class="title">
                        افزودن محصول
                        <img src="Icons/ico-catalog.png" alt="Category" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
             <ajaxToolkit:TabContainer runat="server" ID="ProductTabs" ActiveTabIndex="0" >
             <ajaxToolkit:TabPanel runat="server" ID="pnlProductInfo" HeaderText="اطلاعات محصول">
                <ContentTemplate>
                
                    <uc1:ProductInfo ID="ctrlProductInfo" runat="server" />
                
                </ContentTemplate>
             </ajaxToolkit:TabPanel>
             </ajaxToolkit:TabContainer>
             
        </td>
    </tr>
   
</table>
