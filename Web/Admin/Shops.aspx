<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Shops.aspx.cs" Inherits="Admin_Shops" %>

<%@ Register src="Modules/Shops.ascx" tagname="Shops" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">

    <uc1:Shops ID="Shops1" runat="server" />

</asp:Content>

