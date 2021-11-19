<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="c3305879_Assign2.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>User Registration</h1>
    <p>New to our site? Register an account to purchase products from us!</p>
    <p>* fields are required.</p>
    <asp:Label ID ="lblStatus" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td><b>Account Credentials</b></td>
        </tr>
        <tr>
            <td>Email Address*:</td>
            <td>
                <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="reqEmail" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbxEmail" ErrorMessage="Invalid Email Format!"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Password*:</td>
            <td>
                <asp:TextBox ID="tbxPassword" runat="server" TextMode="Password"></asp:TextBox> 
                <asp:RequiredFieldValidator runat="server" ID="reqPassword" ControlToValidate="tbxPassword" errormessage="Please enter a password!" />
            </td>
        </tr>
        <tr>
            <td><b>Personal Information</b></td>
        </tr>
        <tr>
            <td>First Name:</td>
            <td>
                <asp:TextBox ID="tbxFName" runat="server"></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td>Last Name:</td>
            <td>
                <asp:TextBox ID="tbxLName" runat="server"></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td>Contact Number:</td>
            <td>
                <asp:TextBox ID="tbxContactNo" runat="server"></asp:TextBox> 
            </td>
        </tr>
        <tr>
            <td>Shipping Address:</td>
            <td>
                <asp:TextBox ID="tbxAddress" Width="150%" runat="server"></asp:TextBox> 
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" style="width: 70px" />
            </td>
        </tr>
    </table>
</asp:Content>
