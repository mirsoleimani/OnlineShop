<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EndUserDetails.aspx.cs" Inherits="Admin_EndUserDetails" %>

<%@ Register src="Modules/EndUserDetails.ascx" tagname="EndUserDetails" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:EndUserDetails ID="EndUserDetails1" runat="server" />
</asp:Content>

