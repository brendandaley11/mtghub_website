<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="c3305879_Assign2.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>User Login</h1>
    <p>Enter your login details here.</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td><b>Account Credentials</b></td>
        </tr>
        
        <tr>
            <td>Email Address:</td>
            <td>
                <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="reqEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxEmail" ErrorMessage="Invalid Email Format!"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="tbxPassword" runat="server" TextMode="Password"></asp:TextBox> 
                <asp:RequiredFieldValidator runat="server" ID="reqPassword" ControlToValidate="tbxPassword" errormessage="Please enter a password!" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
