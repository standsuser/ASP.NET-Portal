﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreatingBP.aspx.cs" Inherits="GIU.CreatingBP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Create Local Bachelor Project</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                 <asp:Label runat="server" AssociatedControlID="L_id"><b>lecturer ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="L_id" ID="L_id" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="P_code"><b>project code: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="P_code" ID="P_code" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="t"><b>title : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="t" ID="t" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="m_code"><b>major code: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="m_code" ID="m_code" class="form-control input-group"></asp:TextBox><br />

                    <asp:Label runat="server" AssociatedControlID="d"><b>description : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="d" ID="d" class="form-control input-group"></asp:TextBox><br />




                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="LecturerCreateBP" Text="Accept" />

                    

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
