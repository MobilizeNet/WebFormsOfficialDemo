<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MenuComponents.aspx.cs" Inherits="TestingDemos_WebForms.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="spacePrincipal">
        <div class="rowMenu">
            <div class="columnMenu" id="CheckBoxColumn">
                <div>
                    <h3 style="text-align:center"><strong>Checkbox</strong></h3>
                </div>
                <p>In this section you can test the checkbox component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/CheckBoxForm">Go to Form &raquo;</a>
                </p>
            </div>
            <div class="columnMenu" id="LinkButtonColumn">
                <div>
                    <h3 style="text-align:center"><strong>LinkButton</strong></h3>
                </div>
                <p>In this section you can test the <asp:LinkButton id="LinkButton1" 
                                                                    Text="Link Button"
                                                                    PostBackUrl="https://www.google.com/?hl=es"
                                                                    runat="server"/> component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Contact">Go to Form &raquo;</a>
                </p>
            </div>
            <div class="columnMenu" id="GridviewColumn">
                <div>
                    <h3 style="text-align:center"><strong>Gridview</strong></h3>
                </div>
                <p>In this section you can test the gridview component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/GridViewForm">Go to Form &raquo;</a>
                </p>
            </div>
        </div>
    </div>
    <div class="spaceSecondary">
        <div class="rowMenu">
            <div class="columnMenu" id="DropDownListColumn">
                <div>
                    <h3 style="text-align:center"><strong>DropDownList</strong></h3>
                </div>
                <p>In this section you can test the DropDownList component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/DropDownListForm">Go to Form &raquo;</a>
                </p>
            </div>
            <div class="columnMenu" id="DataListColumn">
                <div>
                    <h3 style="text-align:center"><strong>DataList</strong></h3>
                </div>
                <p>In this section you can test the DropDownList component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/DataListForm">Go to Form &raquo;</a>
                </p>
            </div>
            <div class="columnMenu" id="OtherComponentsColumn">
                <div>
                    <h3 style="text-align:center"><strong>Other components</strong></h3>
                </div>
                <p>In this section you cant test the boundField, templateField, hyperLinkField, commandField</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/OtherComponents">Go to Form &raquo;</a>
                </p>
            </div>
        </div>
    </div>
    <div class="spaceSecondary">
        <div class="rowMenu">
            <div class="columnMenu" id="CalendarColumn">
                <div>
                    <h3 style="text-align:center"><strong>Calendar extender</strong></h3>
                </div>
                <p>In this section you can test the Calendar component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/CalendarForm">Go to Form &raquo;</a>
                </p>
            </div>
            <div class="columnMenu" id="PopUpColumn">
                <div>
                    <h3 style="text-align:center"><strong>Pop up extender</strong></h3>
                </div>
                <p>In this section you can test the Pop up component.</p>
                <p style="float:right">
                    <a class="btn btn-default" runat="server" href="~/Features/PopUpForm">Go to Form &raquo;</a>
                </p>
            </div>
        </div>
    </div>
</asp:Content>
