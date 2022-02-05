<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvancedSearch.ascx.cs" Inherits="Admin_Modules_AdvancedSearch" %>

<%@ Register src="AdvancedSearchByRegistrar.ascx" tagname="AdvancedSearchByRegistrar" tagprefix="uc1" %>
<%@ Register src="AvancedSearchAddressInfoByCategoryID.ascx" tagname="AvancedSearchAddressInfoByCategoryID" tagprefix="uc2" %>

<%@ Register src="AdvancedSearchContactInfoByCategoryID.ascx" tagname="AdvancedSearchContactInfoByCategoryID" tagprefix="uc3" %>

<div class="section-header">
  <div class="title">
        جستجوی پیشرفته
        <img src="Icons/ico-search.png" alt="" />
    </div>
  
</div>
<table border="0" cellspacing="0" cellpadding="0" width="100%" dir="rtl">
    <tr>
        <td>
         
            <ajaxToolkit:TabContainer runat="server" ID="AdvancedSearchTabs" 
                ActiveTabIndex="2">
                <ajaxToolkit:TabPanel runat="server" ID="pnlShopDeputation" HeaderText="نمايندگي">
                    <ContentTemplate>                
                        
                   
                        <uc1:AdvancedSearchByRegistrar ID="AdvancedSearchByRegistrar1" runat="server" />
                        
                   
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlShopAddress" HeaderText="مکانی">
                    <ContentTemplate>                
                                    
                        
                        <uc2:AvancedSearchAddressInfoByCategoryID ID="AvancedSearchAddressInfoByCategoryID1" 
                            runat="server" />
                                    
                        
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="pnlShopContact" HeaderText="تماسی">
                    <ContentTemplate>                  
                                    
                        
                        <uc3:AdvancedSearchContactInfoByCategoryID ID="AdvancedSearchContactInfoByCategoryID1" 
                            runat="server" />
                                    
                        
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
        </td>
    </tr>
</table>