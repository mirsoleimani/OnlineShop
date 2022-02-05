<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="CategoryAdd.aspx.cs" Inherits="Admin_CategoryAdd" %>

<%@ Register src="Modules/CategoryAdd.ascx" tagname="CategoryAdd" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">

    <uc1:CategoryAdd ID="CategoryAdd1" runat="server" />

</asp:Content>

