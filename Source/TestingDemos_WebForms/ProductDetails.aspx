<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="TestingDemos_WebForms.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div style="text-align:center">
            <h4><strong>Product information</strong></h4>
        </div>
        <div>
            <asp:Label ID="idLabel"  style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product details:"></asp:Label>
            <asp:Label ID="idLabelInfo" Font-Bold="true" style="width: 300px;" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="ProductNameLabel"  style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product name: "></asp:Label>
            <asp:Label ID="ProductNameInfoLabel" Font-Bold="true" style="width: 300px;" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="ProductDetailLabel"  style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product details: "></asp:Label>
            <asp:Label ID="ProductDetailInfoLabel" Font-Bold="true" style="width: 300px;" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="ProductCategoryLabel"  style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product category: "></asp:Label>
            <asp:Label ID="ProductCategoryInfoLabel" Font-Bold="true" style="width: 300px;" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="ProductoDetailsLabel"  style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Order details: "></asp:Label>
            <asp:Label ID="ProductoDetailsInfoLabel" Font-Bold="true" style="width: 300px;" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
