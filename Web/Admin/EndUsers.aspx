<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="EndUsers.aspx.cs" Inherits="Admin_EndUsers" %>

<%@ Register src="Modules/EndUsers.ascx" tagname="EndUsers" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">
    <uc1:EndUsers ID="EndUsers1" runat="server" />
</asp:Content>

