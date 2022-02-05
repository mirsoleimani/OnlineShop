<%@ Page Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register Assembly="NetSwf" Namespace="NetControls.NetSwf" TagPrefix="NetControls" %>
<%@ Register Src="Modules/ShopCategoriesList.ascx" TagName="ShopCategoriesList" TagPrefix="uc1" %>
<%@ Register Src="Modules/ShopQuickAccess.ascx" TagName="ShopQuickAccess" TagPrefix="uc2" %>
<%@ Register Src="Modules/Publicity.ascx" TagName="Publicity" TagPrefix="uc3" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderSlideShow" runat="Server">
        <uc3:Publicity ID="Publicity1" runat="server" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" runat="Server">
   <%-- <asp:Image ID="Image2" runat="server" ImageUrl="~/App_Themes/OnlineShopFirozeh/Images/welcom.png" />--%>
  <%--  <uc1:ShopCategoriesList ID="ShopCategoriesList1" runat="server" />--%>
       <%-- <uc3:Publicity ID="Publicity1" runat="server" />--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent"
    runat="Server">
</asp:Content>
