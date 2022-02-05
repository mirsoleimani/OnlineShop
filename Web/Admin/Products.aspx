<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Admin_Products" %>

<%@ Register src="Modules/Products.ascx" tagname="Products" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">

    <uc1:Products ID="Products1" runat="server" />

</asp:Content>

