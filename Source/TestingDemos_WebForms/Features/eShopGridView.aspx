<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="eShopGridView.aspx.cs" Inherits="TestingDemos_WebForms.Features.eShopGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <asp:GridView ID="productList" runat="server" AutoGenerateColumns="false" CssClass="table" EmptyDataText="No data was returned." AllowPaging="True" OnPageIndexChanging="productList_PageIndexChanging" PageSize="6">
            <HeaderStyle CssClass="esh-table-header" />
            <Columns>
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        <asp:Image runat="server" ID="aspimage" ImageUrl='<%# $"/eShopPics/{Eval("PictureFileName")}"%>' CssClass="esh-thumbnail" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="CatalogBrand" HeaderText="Brand" />
                <asp:BoundField DataField="CatalogType" HeaderText="Type" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="AvailableStock" HeaderText="Stock" />
                <asp:BoundField DataField="RestockThreshold" HeaderText="Restock" />
                <asp:BoundField DataField="MaxStockThreshold" HeaderText="Max stock" />
                <asp:TemplateField HeaderText="Options">
                    <ItemTemplate>
                        <asp:HyperLink ID="btnEdit" NavigateUrl='<%# "~/Features/eShopGridView?btn=edit" %>' runat="server">
                            Edit
                        </asp:HyperLink>
                        |
                        <asp:HyperLink ID="btnDetails" NavigateUrl='<%# "~/Features/eShopGridView?btn=details" %>' runat="server">
                            Details
                        </asp:HyperLink>
                        |
                        <asp:HyperLink ID="btnDelete" NavigateUrl='<%# "~/Features/eShopGridView?btn=delete" %>' runat="server">
                            Delete
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerSettings Mode="NextPrevious" NextPageText="Next" PreviousPageText="Previous" />
            <PagerStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />
        </asp:GridView>
    </div>
</asp:Content>
