<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ProductAdd.aspx.cs" Inherits="Admin_ProductAdd" %>

<%@ Register src="Modules/ProductAdd.ascx" tagname="ProductAdd" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:ProductAdd ID="ProductAdd1" runat="server" />
</asp:Content>

