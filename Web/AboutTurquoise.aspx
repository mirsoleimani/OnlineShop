<%@ Page Language="C#" MasterPageFile="~/GeneralMasterPage.master" AutoEventWireup="true" CodeFile="AboutTurquoise.aspx.cs" Inherits="Encyclopedia_of_Turquoise" %>
<%@ MasterType VirtualPath="~/GeneralMasterPage.master" %>
<%@ Register src="Modules/Turquoise.ascx" tagname="Turquoise" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMainContent" Runat="Server">
    <uc1:Turquoise ID="Turquoise" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRightContent" Runat="Server">
</asp:Content>

