<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckBoxForm.aspx.cs" Inherits="TestingDemos_WebForms.CheckBoxForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div class="rowMenu">
            <div class="columnMenuCheckbox">
                <div style="float:right">
                    <div class="col-xs-4">
                        <asp:CheckBox runat="server" AutoPostBack="true" ID="CheckBox1"
                            Text="Checkbox1" CssClass="checkbox" 
                            OnCheckedChanged="CheckBox1_CheckedChanged" 
                            />
                    </div>
                </div>
            </div>
            <div class="columnMenuCheckbox">
                <div class="col-xs-4">
                    <asp:CheckBox runat="server" ID="CheckBox2"
                        Text="Checkbox2" CssClass="checkbox" />
                </div>
            </div>
        </div>
        <div class="centerDivButtons">
            <div class="rowButtons">
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button1" runat="server" Text="Show/hide" Width="150px" OnClick="Button1_Click" />
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button2" runat="server" Text="Checked" Width="150px" OnClick="Button2_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button3" runat="server" Text="Unchecked" Width="150px"/>
                    </div>
                </div>
            </div>
            <div class="rowButtons">
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button4" runat="server" Text="Enable" Width="150px" OnClick="Button4_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button5" runat="server" Text="Visible" Width="150px" OnClick="Button5_Click"/>
                    </div>
                </div>
                <div class="columnButtons">
                    <div>
                        <asp:Button ID="Button6" runat="server" Text="Text" Width="150px" OnClick="Button6_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
