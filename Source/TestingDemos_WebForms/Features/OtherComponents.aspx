<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OtherComponents.aspx.cs" Inherits="TestingDemos_WebForms.OtherComponents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div>
            <h4 style="color:Navy">BoundField, TemplateField, hyperlinkfield, commandfield Example</h4>
            <div>
                <asp:Label ID="ProductNameLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product name:"></asp:Label>
                <asp:TextBox ID="ProductName" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="ProductName" ID="RequiredFieldValidator1" runat="server" ErrorMessage="The product name is required" Display="Dynamic" Text="*" CssClass="validar"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="ProductDetailsLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product details:"></asp:Label>
                <asp:TextBox ID="ProductDetail" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="ProductDetail"
                    ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="The product details is required" 
                    Display="Dynamic" Text="*" 
                    CssClass="validar"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:Label ID="ProductCategory" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product category:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Electronic devices</asp:ListItem>
                                    <asp:ListItem>Tv & Home Appliances</asp:ListItem>
                                    <asp:ListItem>Health & Beauty</asp:ListItem>
                                    <asp:ListItem>Men's Fashion</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="ProductNewLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: center;" runat="server" Text="New?"></asp:Label>
                <asp:CheckBox ID="ProductNew" runat="server" />
            </div>
            <div>
                <asp:Label ID="ProductOdetailsLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Product order details :"></asp:Label>
                <asp:TextBox ID="ProductOdetailsInput" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="ProductOdetailsInput" ID="RequiredFieldValidator3" runat="server" ErrorMessage="The product details is required" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator>
            </div>
            <div class="centerDivButtons">
                <asp:Button ID="AddButton" runat="server" Text="Add new product" OnClick="addButton_Click" />                
            </div>
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:ValidationSummary 
                                  id="valSum" 
                                  runat="server"
                                  ForeColor="Red"
                                  DisplayMode="List"
                                  />
            </div>
            <div>
                <asp:GridView
                    ID="GridView1" 
                    runat="server"
                    AutoGenerateColumns="false"
                    HorizontalAlign="Center"
                    OnRowDataBound="GridView1_RowDataBound"
                    OnRowCommand="GridView1_RowCommand"
                 >
                    <Columns>
                        <asp:BoundField HeaderText="Product ID" DataField="IdProduct" />
                        <asp:BoundField HeaderText="Product Name" DataField="Name" />
                        <asp:TemplateField  HeaderText="Product details" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server"
                                   Text='<%# Eval("Details") %>' Style="text-align: center;"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField  HeaderText="Category">
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList2" runat="server" Width="150px" >
                                    <asp:ListItem>Electronic devices</asp:ListItem>
                                    <asp:ListItem>Tv & Home Appliances</asp:ListItem>
                                    <asp:ListItem>Health & Beauty</asp:ListItem>
                                    <asp:ListItem>Men's Fashion</asp:ListItem>
                                </asp:DropDownList>
                                <asp:HiddenField ID="HiddenId" runat="server" Value='<%# Eval("CategoryIndex") %>'  />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField  HeaderText="New">
                            <ItemTemplate>
                                <asp:CheckBox ID="isNewCheckbox" runat="server" Checked='<%# Eval("IsNew") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:hyperlinkfield text="Details..."
                            DataNavigateUrlFields="IdProduct"
                            DataNavigateUrlFormatString="~/ProductDetails.aspx?IdProduct={0}"
                            headertext="Order Details"/>
                        <asp:commandfield
                            headertext="Edit Controls"/>
                        <asp:TemplateField  HeaderText="Save">
                            <ItemTemplate>
                                <asp:Button ID="SaveButton" runat="server" Text="Save" CommandName="save" CommandArgument='<%# Eval("IdProduct") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
