<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="ImageDetails.aspx.cs" Inherits="ImageDetails" %>

<%@ Register src="Modules/ProductImageDetails.ascx" tagname="ProductImageDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBelowHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
    <uc1:ProductImageDetails ID="ProductImageDetails1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

