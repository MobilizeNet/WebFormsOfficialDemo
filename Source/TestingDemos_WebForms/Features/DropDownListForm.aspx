<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DropDownListForm.aspx.cs" Inherits="TestingDemos_WebForms.DropDownListForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div style="margin-left:39%; padding-top:20px;">
            <asp:DropDownList ID="DropDownList1" runat="server" Width="250px">
            </asp:DropDownList>
        </div>
        <div class="centerDivButtons">
            <div class="rowButtons">
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button1" runat="server" Text="Show/hide" Width="150px" OnClick="Button1_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button2" runat="server" Text="AddItem" Width="150px" OnClick="Button2_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button3" runat="server" Text="DelteItem" Width="150px" OnClick="Button3_Click"/>
                    </div>
                </div>
            </div>
            <div class="rowButtons">
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button4" runat="server" Text="TotalItems" Width="150px" OnClick="Button4_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button6" runat="server" Text="Enable" Width="150px" OnClick="Button6_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button5" runat="server" Text="Set index" Width="150px" OnClick="Button5_Click"/>
                    </div>
                </div>
            </div>
            <div class="rowButtons">
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button7" runat="server" Text="Set data" Width="150px" OnClick="Button7_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
