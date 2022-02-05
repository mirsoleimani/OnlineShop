<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUS" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register src="Modules/Topic.ascx" tagname="Topic" tagprefix="uc1" %>

<%--<%@ Register src="Modules/ContactUs.ascx" tagname="ContactUs" tagprefix="uc2" %>--%>
<%@ Register src="Modules/Guide.ascx" tagname="Guide" tagprefix="uc2" %>
<%--<%@ Register Src="~/Modules/ShopDetail.ascx" TagName="ShopDetail" TagPrefix="OnlineShop" %>--%>

<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBelowHeader" runat="Server">

 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
   <%-- <OnlineShop:ShopDetail ID="ShopInfo1" runat="Server" />--%>
    <uc2:Guide ID="Guide" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

