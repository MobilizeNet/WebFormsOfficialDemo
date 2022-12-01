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
    <style>
        .item {
            display: inline-block;
            width: 90px;
            margin-top: 5px;
            text-align: right;
        }
    </style>
    <div class="spacePrincipal">
        <div>
            <asp:Label ID="nameLabel" CssClass="item" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="name" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rev1" runat="server"
                ControlToValidate="name"
                ForeColor="Red"
                ErrorMessage="The value is required">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="phoneLabel" CssClass="item" runat="server" Text="Phone:"></asp:Label>
            <asp:TextBox ID="phone" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;" runat="server"></asp:TextBox>

        </div>
        <div>
            <asp:Label ID="mailLabel" CssClass="item" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="mail" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:Label ID="mailLabelConfirm" Style="display: inline-block; width: 130px; margin-top: 5px; text-align: right;" runat="server" Text="Confirm email:"></asp:Label>
            <asp:TextBox ID="mailConfirm" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="equalValidator" runat="server"
                ControlToValidate="mail"
                ControlToCompare="mailConfirm"
                ForeColor="Red"
                ErrorMessage="Email should be equal">
            </asp:CompareValidator>
            <div>
                <asp:Label ID="ageLabel" CssClass="item" runat="server" Text="Age:"></asp:Label>
                <asp:TextBox ID="age" runat="server" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;"></asp:TextBox>
                <asp:RangeValidator ID="ageValidator" runat="server" ControlToValidate="age" Type="Integer" ForeColor="Red" Display="Dynamic"
                    MinimumValue="18" MaximumValue="120" ErrorMessage="The age must be a positive number between 18 and 120." />
            </div>
        </div>
        <div>
            <asp:Label ID="confirmLabel" CssClass="item" runat="server" Text="Type<br/> confirm:"></asp:Label>
            <asp:TextBox ID="confirm" Style="font: 1em sans-serif; width: 300px; margin-bottom: 10px; box-sizing: border-box; border: 1px solid #999;" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="cutomeValidator" runat="server"
                ClientValidationFunction="DoSomething"
                ControlToValidate="confirm"
                ForeColor="Red"
                ErrorMessage="It should be equals to: confirm">
            </asp:CustomValidator>
            <asp:Button ID="Button1" runat="server" Text="Add User" OnClick="addButton_Click" ValidateRequestMode="Enabled" />
        </div>
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:ValidationSummary
                ID="valSum"
                runat="server"
                ForeColor="Red"
                DisplayMode="List" />
        </div>
        <hr style="display: none" />
        <asp:GridView ID="GridView1" runat="server" CssClass="centerDivButtons">
        </asp:GridView>
    </div>
</asp:Content>
