<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EndUserRegisterInfo.ascx.cs"
    Inherits="Admin_Modules_EndUserRegister" %>
<%@ Register Src="SimpleTextBox.ascx" TagName="SimpleTextBox" TagPrefix="uc1" %>
<%@ Register Src="PersianCalendar.ascx" TagName="PersianCalendar" TagPrefix="uc2" %>
<%@ Register Src="EmailTextBox.ascx" TagName="EmailTextBox" TagPrefix="uc3" %>
<asp:CreateUserWizard ID="CreateUserWizard1" runat="server" RequireEmail="False"
    DuplicateUserNameErrorMessage="لطفا نام کاربری دیگری انتخاب کنید" OnCreatedUser="CreateUserWizard1_CreatedUser"
    UnknownErrorMessage="کاربرمورد نظر ایجاد نشد، لطفا دوباره سعی کنید" 
    ContinueDestinationPageUrl="" FinishDestinationPageUrl="~/Admin/EndUsers.aspx"
    oncontinuebuttonclick="CreateUserWizard1_ContinueButtonClick" 
    LoginCreatedUser="false" Width="100%">
    <WizardSteps>
        <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
            <ContentTemplate>
                <table class="adminContent" border="0">
                    <tr>
                        <td align="center" colspan="2">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="adminData">
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                ErrorMessage="نام کاربري را وارد کنيد" ToolTip="نام کاربري را وارد کنيد" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            <asp:TextBox ID="UserName" runat="server" CssClass="adminInput"></asp:TextBox>
                        </td>
                        <td class="adminTitle">
                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Text=":نام کاربري"></asp:Label>
                            <img src="Icons/ico-help.gif" alt="" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="adminData">
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                ErrorMessage="کلمه عبور را وارد کنيد" ToolTip="کلمه ي عبور را وارد کنيد" ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="adminInput"></asp:TextBox>
                        </td>
                        <td class="adminTitle">
                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Text=":کمله ي عبور"></asp:Label>
                            <img src="Icons/ico-help.gif" alt="" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="adminData">
                            <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                                ErrorMessage="کلمه ي عبور را تکرار کنيد" ToolTip="کلمه ي عبور را تکرار کنيد"
                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" CssClass="adminInput"></asp:TextBox>
                        </td>
                        <td class="adminTitle">
                            <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword"
                                Text=":تکرار کلمه ي عبور"></asp:Label>
                            <img src="Icons/ico-help.gif" alt="" />
                        </td>
                    </tr>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="تکرار کلمه عبور با کلمه ي عبور يکسان نيست"
                                ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="adminData">
                            <asp:DropDownList runat="Server" ID="ddlEndUserType" CssClass="adminInput" 
                                ondatabound="ddlEndUserType_DataBound"></asp:DropDownList>
                        </td>
                        <td class="adminTitle">
                            <asp:Label ID="lblUserType" runat="Server" Text=":نوع کاربر"></asp:Label>
                            <img src="Icons/ico-help.gif" alt="" />
                        </td>
                    </tr>
                    <tr>
                    
                        <td align="center" colspan="2" style="color: Red;" >
                            <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                        </td>
                        <td></td>
                    </tr>
                </table>
            </ContentTemplate>
            <CustomNavigationTemplate>
                <table border="0" cellspacing="5" style="width: 100%; height: 100%;">
                    <tr align="right">
                        <td align="right" colspan="0">
                            <asp:Button ID="StepNextButton" runat="server" CssClass="button" CommandName="MoveNext"
                                Text="افزودن" ValidationGroup="CreateUserWizard1" />
                        </td>
                    </tr>
                </table>
            </CustomNavigationTemplate>
        </asp:CreateUserWizardStep>
        <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server" >
            <ContentTemplate>
                <table border="0" class="adminContent">
                    <tr>
                        <td class="adminTitle">
                        <asp:Label runat="Server" id="lblComplete" Text="کاربر با موفقيت ايجاد شد"></asp:Label>
                            </td>
                    </tr>
                    <tr>
                        <td align="right" colspan="2" class="adminData">
                            <asp:Button ID="ContinueButton" runat="server" CssClass="button" CausesValidation="False" 
                                CommandName="Continue" Text="ادامه" ValidationGroup="CreateUserWizard1" 
                                 />
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:CompleteWizardStep>
    </WizardSteps>
</asp:CreateUserWizard>
