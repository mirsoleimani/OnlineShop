<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ShopDetails.aspx.cs" Inherits="Admin_ShopDetails" %>

<%@ Register src="Modules/ShopInfo.ascx" tagname="ShopInfo" tagprefix="uc1" %>

<%@ Register src="Modules/ShopDetails.ascx" tagname="ShopDetails" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">


    <uc2:ShopDetails ID="ShopDetails1" runat="server" />


</asp:Content>

