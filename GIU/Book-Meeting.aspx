﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Book-Meeting.aspx.cs" Inherits="GIU.Book_Meeting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>View Unbooked Meetings</h2>

</header>
    <br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                     <asp:Label runat="server" ID="studentidlabel"><b>Student ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="studentid" ID="studentidbox"></asp:TextBox><br /><br />

                     <asp:Label runat="server" ID="meeting"><b>Meeting ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="meetingid" ID="meetingidbox"></asp:TextBox><br /><br />

         
                     &nbsp;<asp:Button ID="book" runat="server" OnClick="book_Click" Text="Book" />


                </div>
            </div>
        </div>
    </div>


    
</section>
</div>
</div>
</section>
</section>
</asp:Content>
