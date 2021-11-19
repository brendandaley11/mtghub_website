<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="c3305879_Assign2.Cart1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <p>Here are all the products you have added to your cart. Once you are happy with it, click the 'Checkout' button and the system will use your profile details to have them shipped out to you!</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvCart" runat="server" CellPadding="5" CellSpacing="4" AutoGenerateColumns="False">
        <Columns>
            
            <asp:BoundField HeaderText="Product Name" DataField="productName" SortExpression="productName" />
            <asp:BoundField HeaderText="Price (per item)" DataField="productPrice" SortExpression="productPrice" />
            <asp:BoundField HeaderText="Amount" DataField="productAmount" SortExpression="productAmount" />

        </Columns>
    </asp:GridView>
    <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
</asp:Content>
