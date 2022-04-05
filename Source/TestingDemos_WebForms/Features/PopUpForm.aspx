<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PopUpForm.aspx.cs" Inherits="TestingDemos_WebForms.Features.PopUpForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div style="margin-left:39%; padding-top:20px;">
            <asp:Button ID="Button1" runat="server" Text="Open the Modal PopUp" />
            <div style="margin-top: 2%;text-align:center">
                <asp:Label ID="informationLabel" runat="server" Text="This was the information sent: "></asp:Label>
            </div>
            <div style="margin-top: 2%;text-align:center">
                <asp:Label ID="nameSentLabel" runat="server" Text="name"></asp:Label>
            </div>
            <div style="margin-top: 2%;text-align:center">
                <asp:Label ID="genderSentLabel" runat="server" Text="gender"></asp:Label>
            </div>
            <div style="margin-top: 2%;text-align:center">
                <asp:Label ID="marriedSentLabel" runat="server" Text="married"></asp:Label>
            </div>
            <div style="margin-top: 2%;text-align:center">
                <asp:Label ID="citySentLabel" runat="server" Text="city"></asp:Label>
            </div>
            <asp:Panel ID="Panel1" runat="server" BackColor="LightBlue" BorderStyle="Groove" Style="display: none">
                <div>
                    <asp:Label ID="nameLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Name:"></asp:Label>
                    <asp:TextBox ID="nameInput" style="font: 1em sans-serif;width: 150px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="genderLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Gender:"></asp:Label>
                <asp:DropDownList ID="genderDropDown" runat="server" Width="150px">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="MarriedLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="Married?"></asp:Label>
                <asp:CheckBox ID="MarriedCheckBox" runat="server" />
                <div>
                    <asp:Label ID="CityLabel" style="display: inline-block;width: 150px; margin-top:5px; text-align: right;" runat="server" Text="City:"></asp:Label>
                    <asp:TextBox ID="CityInput" style="font: 1em sans-serif;width: 150px; margin-bottom:10px; box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button2" runat="server" Text="Cancel"/>
                <asp:Button ID="Button3" runat="server" Text="Send" OnClick="Button1_Click" />
            </asp:Panel>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID ="Panel1" TargetControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>
        </div>
    </div>
</asp:Content>