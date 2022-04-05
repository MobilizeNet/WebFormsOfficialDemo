<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TableForm.aspx.cs" Inherits="TestingDemos_WebForms.TableForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function DoSomething(sender, args) {
            if (args.Value != "18") {
                args.IsValid = false;
                return false;
            }
            args.IsValid = true;
            return true;
        }
    </script>
    <div class="spacePrincipal">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="titleLabel" runat="server" Text="Table test"></asp:Label>
        </div>
        <div>  
            <table>  
                <tr >  
                    <td style="padding-top:23px;">Name  
                    </td>  
                    <td>  
                        <asp:TextBox ID="txtName" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rev1" runat="server"
                            ControlToValidate="txtName"
                            ErrorMessage="The value is required">
                        </asp:RequiredFieldValidator>
                    </td>  
                </tr>  
                <tr>  
                    <td style="padding-top:23px;">Age  
                    </td>  
                    <td>  
                        <asp:TextBox ID="txtAge" runat="server" MaxLength="3"  ></asp:TextBox>
                        <asp:CustomValidator ID="cutomeValidator" runat="server" 
                            ClientValidationFunction="DoSomething"
                            ControlToValidate="txtAge"
                            ForeColor="Red"
                            ErrorMessage="The local function was evaluated and the value is different to 18">
                        </asp:CustomValidator>
                    </td>  
                </tr>  
                <tr>  
                    <td style="padding-top:23px;">Mobile  
                    </td>  
                    <td>  
                        <asp:TextBox ID="txtMobile" runat="server" MaxLength="10" ></asp:TextBox>
                        <asp:Label ID="labelMobile2" runat="server" Text="Confirm mobile"></asp:Label>
                        <asp:TextBox ID="txtMobile2" runat="server" MaxLength="10" ></asp:TextBox> 
                        <asp:CompareValidator ID="equalValidator" runat="server"
                            ControlToValidate="txtMobile"
                            ControlToCompare="txtMobile2"
                            ForeColor="Red"
                            ErrorMessage="The mobile number should be equals in both inputs">
                        </asp:CompareValidator>
                    </td>  
                </tr>  
                <tr>  
                    <td style="padding-top:20px;">Email ID  
                    </td>  
                    <td>  
                        <asp:TextBox ID="txtEmailID" runat="server" placeholder="yourname@server.com"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td rowspan="1" style="padding-top:23px;">  
                        <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click"/>      
                    </td>  
                </tr>  
            </table>
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:ValidationSummary 
                    id="valSum" 
                    runat="server"
                    HeaderText="You must enter a value in the following fields:"
                    DisplayMode="List"/>
                <asp:Label ID="successfulMessage" runat="server" Text="Form sent ;)" Visible="false"></asp:Label>
            </div>
        </div> 
    </div>
</asp:Content>