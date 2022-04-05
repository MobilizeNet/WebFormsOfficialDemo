<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalendarForm.aspx.cs" Inherits="TestingDemos_WebForms.Features.CalendarForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div style="margin-left:39%; padding-top:20px;">
            <asp:TextBox ID="TextBox1" runat="server">
            </asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" PopupButtonID="Button4"/>
        </div>
        <div class="rowButtons">
            <div class="columnButtons">
                <div>
                    <asp:Button ID="Button1" runat="server" Text="Change date" Width="150px" OnClick="Button1_Click"/>
                </div>
            </div>
            <div class="columnButtons">
                <div>
                    <asp:Button ID="Button2" runat="server" Text="Clear input" Width="150px" OnClick="Button2_Click"/>
                </div>
            </div>
            <div class="columnButtons">
                <div>
                    <asp:Button ID="Button3" runat="server" Text="Enable/Disable" Width="150px" OnClick="Button3_Click"/>
                </div>
            </div>
            <div class="columnButtons">
                <div>
                    <asp:Button ID="Button4" runat="server" Text="Show calendar" Width="150px"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>