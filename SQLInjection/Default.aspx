<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SQLInjection._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="FailureText" />
    </p>
    <fieldset>
        <legend>Log in Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="UserName">User name ('OR '1'='1)</asp:Label>
                <asp:TextBox runat="server" ID="UserName" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="The user name field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="The password field is required." />
            </li>
            <li>
                <asp:CheckBox runat="server" ID="RememberMe" />
                <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="checkbox">Remember me?</asp:Label>
            </li>
        </ol>
        <asp:Button runat="server" CommandName="Login" Text="Log in" ID="btnLogin" OnClick="btnLogin_Click" />
    </fieldset>
</asp:Content>
