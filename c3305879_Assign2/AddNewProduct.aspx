<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddNewProduct.aspx.cs" Inherits="c3305879_Assign2.AddNewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add a Product</h1>
    <p>Here you can add a product to our listings. Please provide a name, a price (in AUD) and a description.</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <table>
        <tr>
            <td>Product Name:</td>
            <td><asp:TextBox ID="tbxProductName" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Price:</td>
            <td><asp:TextBox ID="tbxPrice" runat="server" Width="70px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Description:</td>
            <td><asp:TextBox ID="tbxDescription" runat="server" Width="328px" Height="46px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Category:</td>
            <td><asp:TextBox ID="tbxCategory" runat="server" Width="187px"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click " style="height: 26px"/>
</asp:Content>
