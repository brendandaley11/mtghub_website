<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="c3305879_Assign2.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Products</h1>
    <p>Here you can choose to add or remove products from our listings.</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <asp:GridView ID="gvProductList" runat="server" CellPadding="5" CellSpacing="4" AutoGenerateColumns="True">
    </asp:GridView>
    <asp:Button ID="btnAddProduct" runat="server" Text="Add a New Product" OnClick="btnAddProduct_Click" />
</asp:Content>
