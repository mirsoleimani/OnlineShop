<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserLoginView.ascx.cs"
    Inherits="Modules_EndUserLoginView" %>
<table cellspacing="0" cellpadding="0" width="100px" >
    <asp:LoginView ID="LoginView1" runat="server">
        <RoleGroups>
            <asp:RoleGroup Roles="مدیر">
                <ContentTemplate>
                  <tr>
                        <td style="font-size:1.3em">
                        <asp:LoginStatus ID="LoginStatus2" ForeColor="White" runat="server" LoginText="ورود" LogoutText="خروج" />
                        </td>
                    </tr>
                    <%--  <tr>
                        <td class="loginViewContent">
                            <asp:LoginName runat="Server" ID="LoginName1" FormatString="<br/><b>مدير</b><br/><b>سلام</b>" />
                        </td>
                    </tr>
                    <tr>
                        <td class="loginViewContent">
                        <asp:LoginStatus ID="LoginStatus2" runat="server" LoginText="ورود" LogoutText="خروج" />
                        </td>
                    </tr>
                    <tr>
                        <td class="loginViewContent">
                            <asp:HyperLink runat="Server" ID="hlAdminHomePage" NavigateUrl="~/Admin/Default.aspx"
                            Text="مديريت سايت"></asp:HyperLink>
                        </td>
                    </tr>--%>
                </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="نمایندگی">
            <ContentTemplate>
            <tr>
                        <td style="font-size:1.3em">
                        <asp:LoginStatus ID="LoginStatus2" ForeColor="White" runat="server" LoginText="ورود" LogoutText="خروج" />
                        </td>
                    </tr>
                    </ContentTemplate>
            </asp:RoleGroup>
            <asp:RoleGroup Roles="مدیر">
            </asp:RoleGroup>
        </RoleGroups>
        <AnonymousTemplate>
            <tr>
                <td style="padding-right:5px; color:White">
                    <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="ورود" LogoutText="خروج" />
                </td>
            </tr>
            <%--  <tr>
                <td class="loginViewTitle">
                    خوش آمديد
                </td>
            </tr>
            <tr>
                <td class="loginViewContent">
                </td>
            </tr>--%>
        </AnonymousTemplate>
    </asp:LoginView>
</table>
