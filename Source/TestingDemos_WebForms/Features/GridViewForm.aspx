<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewForm.aspx.cs" Inherits="TestingDemos_WebForms.GridViewForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function DoSomething(sender, args) {
            if (args.Value != "confirm") {
                args.IsValid = false;
                return false;
            }
            args.IsValid = true;
            return true;
        }
    </script>
    <div class="spacePrincipal">
        <div>
            <asp:Label ID="nameLabel" style="display: inline-block;width: 90px; margin-top:5px; text-align: right;" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="name" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rev1" runat="server"
                ControlToValidate="name"
                ForeColor="Red"
                ErrorMessage="The value is required">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="phoneLabel" style="display: inline-block;width: 90px; margin-top:5px; text-align: right;" runat="server" Text="Phone:"></asp:Label>
            <asp:TextBox ID="phone" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="mailLabel" style="display: inline-block;width: 85px; margin-top:5px; text-align: right;" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="mail" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:Label ID="mailLabelConfirm" style="display: inline-block;width: 130px; margin-top:5px; text-align: right;" runat="server" Text="Confirm email:"></asp:Label>
            <asp:TextBox ID="mailConfirm" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="equalValidator" runat="server"
                ControlToValidate="mail"
                ControlToCompare="mailConfirm"
                ForeColor="Red"
                ErrorMessage="Email should be equal">
            </asp:CompareValidator>
        </div>
        <div>
            <asp:Label ID="confirmLabel" style="display: inline-block;width: 132px; margin-top:5px; text-align: right;" runat="server" Text="Type confirm:"></asp:Label>
            <asp:TextBox ID="confirm" style="font: 1em sans-serif;width: 300px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cutomeValidator" runat="server" 
                ClientValidationFunction="DoSomething"
                ControlToValidate="confirm"
                ForeColor="Red"
                ErrorMessage="It should be equals to: confirm">
            </asp:CustomValidator>
            <asp:Button ID="Button1" runat="server" Text="Add User" OnClick="addButton_Click" />
        </div>
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:ValidationSummary 
                              id="valSum" 
                              runat="server"
                              ForeColor="Red"
                              DisplayMode="List"
                              />
        </div>
        <hr style="display:none" />
        <asp:GridView ID="GridView1" runat="server" CssClass="centerDivButtons">
        </asp:GridView>
    </div>
</asp:Content>
