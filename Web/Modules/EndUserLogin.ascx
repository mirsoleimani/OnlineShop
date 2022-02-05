<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserLogin.ascx.cs" Inherits="Modules_EndUserLogin" %>
<table border="0" cellspacing="0" cellpadding="0" style="float: right; text-align: right"
        width="100%">
        <tr>
  <td  class="loginLeft">
            &nbsp
            </td>
            <td>
            <asp:Panel runat="Server" id="pnlLogin"
            DefaultButton = "Login1$LoginButton">
                <asp:Login ID="Login1" runat="server"  LoginButtonStyle-CssClass="button"
                    TextBoxStyle-CssClass="textbox" CssClass="login"  
                    DestinationPageUrl="Default.aspx" 
                    FailureText="ورد موفقیت آمیز نبود، دوباره سعی کنید"                    >
                    <TextBoxStyle CssClass="textbox" />
                    <LoginButtonStyle CssClass="button" />
                    <LayoutTemplate>
                        <table border="0" cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                            <tr>
                                <td>
                                    <table border="0" cellpadding="0" width="300px">
                                        <tr>
                                            <td align="center" colspan="2" class="content-title">
                                                ورود
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" valign="bottom" width="65%">
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                                    ErrorMessage="نام کاربري را وارد کنيد" ToolTip="نام کاربري را وارد کنيد" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                <asp:TextBox ID="UserName" runat="server" CssClass="textbox"></asp:TextBox>
                                            </td>
                                            <td align="right" valign="bottom">
                                                <asp:Label ID="UserNameLabel" runat="server" CssClass="content-title" AssociatedControlID="UserName">:نام کاربري</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" valign="bottom">
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                                    ErrorMessage="کلمه ي عبور را وارد کنيد" ToolTip="کلمه ي عبور را وارد کنيد" ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                <asp:TextBox ID="Password" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                                            </td>
                                            <td align="right" valign="bottom">
                                                <asp:Label ID="PasswordLabel" runat="server" CssClass="content-title" AssociatedControlID="Password">:کلمه ي عبور</asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td  align="center">
                                                <asp:CheckBox ID="RememberMe" CssClass="content-title" runat="server" 
                                                    Text="مرا بخاطر بسپار" />
                                            </td>
                                            <td></td>
                                        </tr>
                                        <tr>
                                            <td align="center" colspan="2" style="color: Red;">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="right" colspan="2">
                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="button"
                                                    Text="ورود" ValidationGroup="Login1" onclick="LoginButton_Click" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:Login>
                </asp:Panel>
            </td>
          
        </tr>
    </table>