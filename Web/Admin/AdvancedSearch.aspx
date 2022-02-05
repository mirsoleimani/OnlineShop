<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdvancedSearch.aspx.cs" Inherits="Admin_AdvancedSearch" %>

<%@ Register src="Modules/AdvancedSearch.ascx" tagname="AdvancedSearch" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:AdvancedSearch ID="AdvancedSearch1" runat="server" />
</asp:Content>

