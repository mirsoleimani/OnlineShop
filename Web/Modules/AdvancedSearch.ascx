<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdvancedSearch.ascx.cs"
    Inherits="Modules_AdvancedSearch" %>

    
<%@ Register src="ShopAdvancedAddressSearchBox.ascx" tagname="ShopAdvancedAddressSearchBox" tagprefix="uc1" %>

    
<%@ Register src="ShopAdvancedContactSearchBox.ascx" tagname="ShopAdvancedContactSearchBox" tagprefix="uc2" %>


    
<%@ Register src="ShopAdvancedCareerSearchBox.ascx" tagname="ShopAdvancedCareerSearchBox" tagprefix="uc3" %>


    
<ajaxToolkit:Accordion ID="Accordion1" runat="server"
TransitionDuration="200" 
      AutoSize="Fill"
      FadeTransitions="true"
      SelectedIndex="0" Height="400px" Width="100%"
      BorderWidth="0px">
<Panes>
    <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server" 
        >
         <Header>
         مکاني
         </Header>
      <Content>
    <asp:Panel runat="Server" >
       <uc1:ShopAdvancedAddressSearchBox ID="ShopAdvancedAddressSearchBox1" runat="server" />
     </asp:Panel> 
      </Content>
        </ajaxToolkit:AccordionPane>
        <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server" 
        >
        <Header>
        تماسي
        </Header>
      <Content>
      <uc2:ShopAdvancedContactSearchBox ID="ShopAdvancedContactSearchBox1" 
    runat="server" />
      </Content>
        </ajaxToolkit:AccordionPane>
                <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server">
        <Header>
        شغلي
        </Header>
      <Content>
     
<uc3:ShopAdvancedCareerSearchBox ID="ShopAdvancedCareerSearchBox1" 
    runat="server" />
      </Content>
        </ajaxToolkit:AccordionPane>
</Panes>
</ajaxToolkit:Accordion>





