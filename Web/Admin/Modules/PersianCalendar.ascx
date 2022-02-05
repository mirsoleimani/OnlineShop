<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PersianCalendar.ascx.cs"
    Inherits="Admin_Modules_PersianCalendar" %>
    <div>
<asp:Image ID="ibtnDate" runat="server" ImageUrl="~/App_Themes/OnlineShopAdmin/Images/Calendar_scheduleHS.png" />
<ajaxToolkit:PopupControlExtender ID="pceDate" runat="Server" PopupControlID="pnlDate"
    TargetControlID="txtDate" Position="Bottom">
</ajaxToolkit:PopupControlExtender>
<asp:Panel ID="pnlDate" runat="Server">
    <asp:UpdatePanel ID="upnlDate" runat="Server">
        <ContentTemplate>
            <center>
                <asp:Calendar runat="Server" ID="cldDate" BackColor="White" BorderColor="#999999"
                    CellPadding="4" DayNameFormat="Full" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black"
                    Height="180px" FirstDayOfWeek="Saturday" OnSelectionChanged="cldDate_SelectionChanged"
                    Width="200px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                </asp:Calendar>
           
                    
                </center>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Panel>
<asp:TextBox ID="txtDate" runat="server" CssClass="adminInputNoWidth" ></asp:TextBox>

</div>
