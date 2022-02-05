<%@ Page Title="" Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register src="Modules/AboutUs.ascx" tagname="AboutUs" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
    <uc1:AboutUs ID="AboutUs1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

