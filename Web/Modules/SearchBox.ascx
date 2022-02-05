<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SearchBox.ascx.cs" Inherits="Modules_SearchBox" %>
 <%@ Register src="ShopSearchBox.ascx" tagname="ShopSearchBox" tagprefix="uc1" %>
 <%@ Register src="ProductSearchBox.ascx" tagname="ProductSearchBox" tagprefix="uc2" %>
 
 <table border="0" cellspacing="0" cellpadding="0" width="100%" style="padding-top: 0px;">
        <tr align="center" dir="rtl">
            <td>
               
                <ajaxToolkit:TabContainer ID="TabContainer1" runat="server"  ActiveTabIndex="0">
                
                <ajaxToolkit:TabPanel id="pnlShopSearch" runat="Server"  HeaderText="فروشگاه">
                
                    <ContentTemplate>
                        <uc1:ShopSearchBox ID="ShopSearchBox1" runat="server" />
                    </ContentTemplate>
                
                </ajaxToolkit:TabPanel>
                 
                <ajaxToolkit:TabPanel id="pnlProductSearch" runat="Server" HeaderText="محصول">
                
                    <ContentTemplate>
                        <uc2:ProductSearchBox ID="ProductSearchBox1" runat="server" />
                    </ContentTemplate>
                
                </ajaxToolkit:TabPanel>
                
                </ajaxToolkit:TabContainer>
               </td>
           
        </tr>
    </table>