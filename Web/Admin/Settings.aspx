<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Admin_Settings" %>

<%@ Register src="Modules/Settings.ascx" tagname="Settings" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">


    <uc1:Settings ID="Settings1" runat="server" />


</asp:Content>

