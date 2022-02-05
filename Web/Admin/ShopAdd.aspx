<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="ShopAdd.aspx.cs" Inherits="Admin_ShopAdd" %>

<%@ Register src="Modules/ShopAdd.ascx" tagname="ShopAdd" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholderAdmin" Runat="Server">

    <uc1:ShopAdd ID="ctrlShopAdd" runat="server" />

</asp:Content>

