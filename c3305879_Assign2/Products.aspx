<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="c3305879_Assign2.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Products</h1>
    <p>Here are a list of our Magic: The Gathering products. Note that you must be logged in to add products to your cart.</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>

    <asp:GridView ID="gvProductList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvProductList_SelectedIndexChanged" CellPadding="5" CellSpacing="4" AutoGenerateColumns="False">
        <Columns>
            
            <asp:BoundField HeaderText="Product Name" DataField="productName" SortExpression="productName" />
            <asp:BoundField HeaderText="Product Price" DataField="productPrice" SortExpression="productPrice" />
            <asp:BoundField HeaderText="Description" DataField="productDescription" SortExpression="productDescription" />
            <asp:BoundField HeaderText="Category" DataField="productCategory" SortExpression="productCategory" />

        </Columns>
    </asp:GridView>
    <h2>Currently Selected Item</h2>
    <p>Product: </p>
    <asp:Label ID="lblProductName" runat="server" Text="None"></asp:Label>
    <br />
    <p>Price: </p>
    <asp:Label ID="lblProductPrice" runat="server" Text="None"></asp:Label>
    <br />
    <p>Description: </p>
    <asp:Label ID="lblProductDescription" runat="server" Text="None"></asp:Label>
    <br />
    <asp:Label ID="lblAmount" runat="server" Text="Amount:" Visible=false></asp:Label>
    <asp:DropDownList ID="ddlAmount" runat="server" Visible=false>
        <asp:ListItem Selected="True" Value=1> 1 </asp:ListItem>
        <asp:ListItem Value=2> 2 </asp:ListItem>
        <asp:ListItem Value=3> 3 </asp:ListItem>
        <asp:ListItem Value=4> 4 </asp:ListItem>
        <asp:ListItem Value=5> 5 </asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" Visible="false"/>
</asp:Content>
