<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="ProductSearchResult.aspx.cs" Inherits="ProductSearchResult" %>

<%@ Register src="Modules/ProductsList.ascx" tagname="ProductsList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBelowHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
    <uc1:ProductsList ID="ProductsList1" runat="server" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

