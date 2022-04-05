<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataListForm.aspx.cs" Inherits="TestingDemos_WebForms.DataListForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div style="padding-top: 2%;text-align:left">
            <asp:Label ID="Label1" style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Id:"></asp:Label>
            <asp:TextBox ID="idTextbox" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top: 2%;text-align:left">
            <asp:Label ID="Label2" style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="nameTextbox" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top: 2%;text-align:left">
            <asp:Label ID="Label3" style="display: inline-block;width: 90px;text-align: right;" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="emailTextbox" style="font: 1em sans-serif;width: 300px;box-sizing: border-box;border: 1px solid #999;" runat="server"></asp:TextBox>
        </div>
        <div style="padding-top: 2%;text-align:center">
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
        <div class="centerDivButtons">
            <asp:DataList ID="DataList1" runat="server">  
                <ItemTemplate>  
                    <table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;   
                    border: dashed 2px #04AFEF; background-color: #FFFFFF">  
                        <tr>  
                            <td>
                                <b>Id: </b><asp:Label ID="Label5" runat="server" Text='<%# Bind("Id") %>'></asp:Label><br /> 
                                <b>Name: </b><asp:Label ID="Label4" runat="server" Text='<%# Bind("Name") %>'></asp:Label><br /> 
                                <b>Email: </b><asp:Label ID="Label7" runat="server" Text='<%# Bind("Email") %>'></asp:Label><br /> 
                            </td>  
                        </tr>  
                    </table>  
                </ItemTemplate>  
            </asp:DataList> 
        </div>
    </div>
</asp:Content>
