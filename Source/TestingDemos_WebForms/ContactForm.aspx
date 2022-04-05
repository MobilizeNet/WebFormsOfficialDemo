<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="TestingDemos_WebForms.ContactForm" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container cuerpo">
        <div class="row contacto">
            <div class="col-md-12">
                <h1>Contact Form</h1>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="AllValidators" CssClass="validar" />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Names: "></asp:Label>
                    <asp:TextBox ID="txtnombres" runat="server" CssClass="form-control" Visible="false"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ControlToValidate="txtnombres" ID="RequiredFieldValidator1" runat="server" ErrorMessage="The names are requierd" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Names only must have letters" Text="Names only must have letters" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txtnombres" ValidationExpression="[A-Za-z ]*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Last Names: "></asp:Label><asp:TextBox ID="txtapellidos" runat="server" CssClass="form-control"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ControlToValidate="txtapellidos" ID="RequiredFieldValidator2" runat="server" ErrorMessage="The last names are required" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="The last names must only contains letters" Text="The last names must only contains letters" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txtapellidos" ValidationExpression="[A-Za-z ]*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label><asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ControlToValidate="txtemail" ID="RequiredFieldValidator3" runat="server" ErrorMessage="The email required" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="The email addresses must been in the format name@domain.xyz." ControlToValidate="txtemail" Display="Dynamic" Text="not valid format" ValidationGroup="All Validators" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Phone number: "></asp:Label><asp:TextBox ID="txttelefono" runat="server" CssClass="form-control"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ControlToValidate="txttelefono" ID="RequiredFieldValidator4" runat="server" ErrorMessage="The phone number is required" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="The phone number must only contains numbers" Text="The phone number must only contains numbers" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txttelefono" ValidationExpression="\d+" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Message: "></asp:Label><asp:TextBox ID="txtmensaje" runat="server" CssClass="form-control" Height="160px"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ControlToValidate="txtmensaje" ID="RequiredFieldValidator5" runat="server" ErrorMessage="The message is required." Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator>
                </div>
                <asp:Button ID="enviar" runat="server" Text="Send" CssClass="btn btn-default" ValidationGroup="AllValidators" OnClick="enviar_Click" />
            </div>
            <asp:Label ID="message" runat="server" Text="Label" CssClass="mensaje" ForeColor="Blue" Width="68px"></asp:Label><br />
        </div>
    </div>
</asp:Content>
