<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="c3305879_Assign2.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Users</h1>
    <p>Here you can view user accounts registered on MTG Hub.</p>
    <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
    <asp:GridView ID="gvUserList" runat="server" CellPadding="5" CellSpacing="4" AutoGenerateColumns="True">
    </asp:GridView>
</asp:Content>
