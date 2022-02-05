<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactUs.ascx.cs" Inherits="Modules_ContactUs" %>

<table width="100%" height="100%" style="background-color:White" border="0" cellpadding="0" cellspacing="0" >
    <tr  valign="top">
        <td height="100%" align="center">
            <table width="100%" border="0" cellpadding="0" cellspacing="0"  style="background-position: top right;
                background-repeat: no-repeat">
                
                <tr>
                    <td height="100%" align="center" valign="top"  bgcolor="" style="background-repeat: repeat-y;
                        background-position: top left">
                        <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0" background=""
                            style="background-repeat: repeat-x; background-position: top">
                            <tr>
                                <td align="right" valign="top">
                                <asp:ImageButton ID="ImageButton3"  ImageUrl="~/App_Themes/OnlineShopFirozeh/Images/map.jpg" OnClick="test_Click" Width="100px" Height="100px" runat="server" />
                                <asp:ImageButton ID="ImageButton2"  ImageUrl="~/App_Themes/OnlineShopFirozeh/Images/addr.png"  runat="server" />                      
                                </td>
                                
                            </tr>
                             <tr>
                                <td align="right" valign="top">
                                    <asp:ImageButton ID="ImageButton1"  ImageUrl="~/App_Themes/OnlineShopFirozeh/Images/email.png"  runat="server" />
                             </td>
                            </tr>
                            <%--commented by elahe--%>
                           <%-- <tr align="center" valign="top">
                                <td height="100%">
                                    <div align="center" >
                                        <table width="420" border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                
                                                    <td class="content-title" height="28" align="right" valign="top" style="text-align: right">
                                                        ایمیل
                                                        <asp:RequiredFieldValidator ID="requiredEmail" runat="server" ControlToValidate="textEmail"
                                                            Display="Dynamic" EnableClientScript="False" ErrorMessage="<br />لطفا ادرس ايميل خود را وارد کنيد">
                                                        </asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="regularexpEmail" runat="server" ControlToValidate="textEmail"
                                                            Display="Dynamic" EnableClientScript="False" ErrorMessage="<br />لطفاادرس ايميل معتبر وارد کنيد"
                                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                                        </asp:RegularExpressionValidator><br />
                                                        <asp:TextBox ID="textEmail" runat="server" CssClass=textbox></asp:TextBox>
                                                        <td class="content-title" height="28" align="left" valign="top" style="width: 191px">
                                                    نام
                                                    <asp:RequiredFieldValidator ID="requiredName" runat="server" ControlToValidate="textName"
                                                        Display="Dynamic" EnableClientScript="False" ErrorMessage="<br/>لطفا نام خود را وارد کنيد">
                                                    </asp:RequiredFieldValidator><br />
                                                    <asp:TextBox ID="textName" runat="server" CssClass=textbox></asp:TextBox>
                                            </tr>
                                            <tr>
                                                <td>
                                                  <!--<img src="images/spacer.gif" width="1" height="10" />  -->  
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="content-title" colspan="2" align="right" valign="top">
                                                    پیام<br />
                                                    <asp:TextBox ID="textComment" TextMode="MultiLine" runat="server" CssClass="textbox"
                                                        Height="75px" Width="100%"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <!-- <img src="images/spacer.gif" width="1" height="5" /> -->
                                                </td>
                                            </tr>
                                            <tr align="right">
                                                <td  colspan="2" valign="bottom" style="height: 17px; padding-right:10px;">
                                                    <asp:Button ID="commandReset" runat="server" Text="پیش فرض" CausesValidation="False"
                                                        OnClick="commandReset_Click" CssClass="button" />&nbsp;
                                                    <asp:Button ID="commandSubmit" runat="server" OnClick="commandSubmit_Click" Text="ثبت"
                                                        CssClass="button" />&nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </td>
                            </tr>--%>
                            <tr>
                                <td>
                                   <!-- <img src="images/spacer.gif" width="1" height="15" /> --> 
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
