<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Admin_ShopCategories" %>



<%@ Register src="Modules/Categories.ascx" tagname="Categories" tagprefix="uc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">


    <uc1:Categories ID="Categories1" runat="server" />


</asp:Content>

