<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EnhancedCalendar.ascx.cs"
    Inherits="CustomControls_EnhancedCalendar" %>
<asp:Calendar ID="calDate" runat="server" OnSelectionChanged="calDate_SelectionChanged"
    BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest"
    Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
    <WeekendDayStyle BackColor="#CCCCFF" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
</asp:Calendar><asp:LinkButton ID="btnPrevYear" runat="server" OnClick="btnPrevYear_Click" Text="<<"
    Visible="False" ForeColor="#CCCCFF" ToolTip="Go to the previous year" /><asp:LinkButton ID="btnNextYear" runat="server" OnClick="btnNextYear_Click" Text=">>"
    Visible="False" ForeColor="#CCCCFF" ToolTip="Go to the next year" />