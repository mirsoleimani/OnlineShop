<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EndUserAdd.aspx.cs" Inherits="Admin_EndUserAdd" %>

<%@ Register src="Modules/EndUserAdd.ascx" tagname="EndUserAdd" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:EndUserAdd ID="EndUserAdd1" runat="server" />
</asp:Content>

