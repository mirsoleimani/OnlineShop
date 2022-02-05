<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="ShopCategories.aspx.cs" Inherits="Categories" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register src="Modules/ShopCategoriesList.ascx" tagname="ShopCategoriesList" tagprefix="uc1" %>

<%@ Register src="Modules/Topic.ascx" tagname="Topic" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBelowHeader" runat="Server">

    <uc2:Topic ID="Topic1" runat="server" TopicName="گروها" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">

    <uc1:ShopCategoriesList ID="ShopCategoriesList1" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

