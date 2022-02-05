<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ProductDetails.aspx.cs" Inherits="Admin_ProductDetails" %>

<%@ Register src="Modules/ProductDetails.ascx" tagname="ProductDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:ProductDetails ID="ProductDetails1" runat="server" />
</asp:Content>

