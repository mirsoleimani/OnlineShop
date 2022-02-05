<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="Shop.aspx.cs" Inherits="Shop" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register src="Modules/ShopDetails.ascx" tagname="ShopDetails" tagprefix="uc1" %>



<%@ Register src="Modules/ProductsList.ascx" tagname="ProductsList" tagprefix="uc2" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBelowHeader" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
    
   
    
    <uc1:ShopDetails ID="ShopDetails1" runat="server" />
     <uc2:ProductsList ID="ProductsList1" runat="server" />
    </asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

