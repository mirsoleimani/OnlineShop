<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register Assembly="NetSwf" Namespace="NetControls.NetSwf" TagPrefix="NetControls" %>
<%@ Register Src="Modules/ShopCategoriesList.ascx" TagName="ShopCategoriesList" TagPrefix="uc1" %>
<%@ Register Src="Modules/ShopQuickAccess.ascx" TagName="ShopQuickAccess" TagPrefix="uc2" %>
<%@ Register Src="Modules/Publicity.ascx" TagName="Publicity1" TagPrefix="uc3" %>
<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>--%>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderSlideShow" runat="Server">
                <table>
                    <tr>
                     <td>
                        <asp:Image ID="Image1" runat="server" Height="300" Width="450" />

                        <ajaxToolkit:SlideShowExtender ID="SlideShowExtender1" runat="server" TargetControlID="Image1"
                             SlideShowServicePath="wsSlideShow.asmx" SlideShowServiceMethod="GetSlides" AutoPlay="true"
                             Loop="true" SlideShowAnimationType="SlideRight">
                        </ajaxToolkit:SlideShowExtender>
                       </td>
                       <td>
                        <img width="750" height="300" src="App_Themes/OnlineShopFirozeh/Images/shop.jpg"/>
                       </td>
                    </tr>
                 </table>   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">
  <%--  <uc1:ShopCategoriesList ID="ShopCategoriesList1" runat="server" />--%>
 <uc3:Publicity1 ID="Publicity1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent"
    runat="Server">
</asp:Content>
