<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUsers.ascx.cs" Inherits="Admin_Modules_Customers" %>
<div class="section-header">
    <div class="title">
        مديريت کاربر ها
        <img src="Icons/ico-catalog.png" alt="" />
    </div>
    <div class="options">
        <asp:Button runat="Server" Text="جستجو" ID="btnSearch" ToolTip="جستجوي کاربر" CssClass="button"
            OnClick="btnSearch_Click" />
        <input type="button" onclick="location.href='EndUserAdd.aspx'" value="افزودن" id="btnAdd"
            class="button" title="افزودن کاربر " />
    </div>
</div>
<table border="0" cellspacing="0" cellpadding="0" width="100%" class="adminContent">
    <tr>
        <td class="adminData">
            <asp:TextBox runat="Server" ID="txtFirstName" CssClass="adminInput" ToolTip="نام کاربر مورد نظر را براي جستجو وارد کنيد"></asp:TextBox>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblName" Text=":نام "></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox runat="Server" ID="txtLastName" CssClass="adminInput" ToolTip="فاميل کاربر مورد نظر را براي جستجو وارد کنيد"></asp:TextBox>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblFamily" Text=":فاميل"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td class="adminData">
            <asp:TextBox runat="Server" ID="txtUserName" CssClass="adminInput" ToolTip="نام کاربري مورد نظر را براي جستجو وارد کنيد"></asp:TextBox>
        </td>
        <td class="adminTitle">
            <asp:Label runat="Server" ID="lblUserName" Text=":نام کاربري"></asp:Label>
            <img src="Icons/ico-help.gif" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
                    <asp:GridView ID="gvEndUsersSearch" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvEndUsersSearch_PageIndexChanging" PageSize="30">
                <Columns>
                    <asp:TemplateField HeaderText="نام" ItemStyle-Width="50%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("FirstName").ToString()+" "+Eval("LastName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نام کاربري" ItemStyle-Width="30%">
                        <ItemTemplate>
                            <asp:Label ID="lblUserName" runat="Server" Text='<%#Server.HtmlEncode(Eval("UserName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نوع کاربر" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblUserName" Text='<%#Server.HtmlEncode(Eval("RoleName").ToString()) %>' runat="Server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="10%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/EndUserDetails.aspx?EndUserID={0}",Eval("EndUserID"))) %>'
                                Text="نمايش کاربر"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:GridView ID="gvEndUsers" runat="Server" AutoGenerateColumns="false" Width="100%"
                AllowPaging="true" OnPageIndexChanging="gvEndUsers_PageIndexChanging" PageSize="30"
                OnDataBinding="gvEndUsers_DataBinding">
                <Columns>
                    <asp:TemplateField HeaderText="نام" ItemStyle-Width="50%">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="Server" Text='<%#Server.HtmlEncode(Eval("FirstName").ToString()+" "+Eval("LastName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نام کاربري" ItemStyle-Width="30%">
                        <ItemTemplate>
                            <asp:Label ID="lblUserName" runat="Server" Text='<%#Server.HtmlEncode(Eval("UserName").ToString()) %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نوع کاربر" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:Label ID="lblUserName" Text='<%#Server.HtmlEncode(Eval("RoleName").ToString()) %>' runat="Server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="نمايش" ItemStyle-Width="10%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:HyperLink ID="hlView" runat="Server" NavigateUrl='<%#Page.ResolveUrl("~/"+string.Format("admin/EndUserDetails.aspx?EndUserID={0}",Eval("EndUserID"))) %>'
                                Text="نمايش کاربر"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </td>
    </tr>
</table>
