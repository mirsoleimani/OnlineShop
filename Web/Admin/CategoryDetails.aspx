<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="CategoryDetails.aspx.cs" Inherits="Admin_CategoryDetails" %>

<%@ Register src="Modules/CategoryDetails.ascx" tagname="CategoryDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">

    <uc1:CategoryDetails ID="CategoryDetails1" runat="server" />

</asp:Content>

