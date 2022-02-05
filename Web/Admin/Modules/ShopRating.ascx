<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ShopRating.ascx.cs" Inherits="Admin_Modules_ShopRating" %>
<div>
<ajaxToolkit:Rating ID="ShopRating" AutoPostBack="true" runat="Server" CurrentRating="1"
    MaxRating="5" StarCssClass="ratingStar" WaitingStarCssClass="savedRatingStar"
    FilledStarCssClass="filledRatingStar" EmptyStarCssClass="emptyRatingStar" 
    Style="float: right;" onchanged="ShopRating_Changed" EnableViewState="true">
</ajaxToolkit:Rating>
</div>
