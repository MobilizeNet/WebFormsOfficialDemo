<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MailForm.aspx.cs" Inherits="TestingDemos_WebForms.MailForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="background-color:#F4F4F4; margin-top:6%;text-align:center" runat="server">
        <hr />
        <div>
            <asp:Label style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Name:" ID="Label4"></asp:Label> <!-- Manual Change for bug 410749 -->
                <asp:TextBox ID="TextBox1" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;line-height: normal;" runat="server"></asp:TextBox>
        </div>
        <div style="margin-top: 2%;text-align:center">
            <asp:Label ID="Label1" style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="TextBox2" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
        </div>
        <div style="margin-top: 2%;text-align:center">
            <asp:Label ID="Label2" style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Message:"></asp:Label>
            <asp:TextBox ID="TextBox3" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
        <div style="margin-top: 2%; margin-bottom:2%; text-align:center; margin-left:1%">
            <asp:Button ID="Button1" style="text-align: center" runat="server" Text="Send your message" OnClick="Button1_Click" />
        </div>
        <div style="margin-top: 2%;">
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
        <hr />
    </div>
</asp:Content>
