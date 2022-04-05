<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestingDemos_WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="margin-top: 6%;">
        <h1>Web Forms</h1>
        <p class="lead">This is a basic demo application in order to test several features of WebForms to WebMap Conversion. Please feel to add more testing content.</p>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Basic Send Mail Form</h2>
            <p>
                This is a very basic form that contains controls like: labels, textboxes and buttons.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/MailForm">Go to Form &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Contact to Travel Agency</h2>
            <p>
                This is a basic form that test some control and adittional integrations with master pages.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/ContactForm">Go to Form &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Look for our offices</h2>
            <p>
                This is a basic form that test some control and adittional integrations with master pages.
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Features/TableForm.aspx">Go to Form &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
