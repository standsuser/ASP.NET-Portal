﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="5e.aspx.cs" Inherits="GIU._5e" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>View Meetings</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">



                             
                    <asp:GridView ID="meetings" runat="server" Visible="true" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10" >
                    </asp:GridView>
         
                    <asp:Label runat="server" AssociatedControlID="m_id"><b>Meeting ID: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="m_id" ID="m_id" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="L_id"><b>Lecturer  ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="L_id" ID="L_id" class="form-control input-group"></asp:TextBox><br /></asp:TextBox><br />

                  



                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick=" ViewMeetingLecturer5e" Text="Accept" />

                    

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