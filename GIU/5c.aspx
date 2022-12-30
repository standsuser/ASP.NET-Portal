<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="5c.aspx.cs" Inherits="GIU._5c" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>See Users</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                 <asp:Label runat="server" AssociatedControlID="L_id"><b>lecturer ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="L_id" ID="L_id" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="ST"><b>start time: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="ST" ID="ST" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="ET"><b>end time  : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="ET" ID="ET" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="d"><b>date: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="d" ID="d" class="form-control input-group"></asp:TextBox><br />

                    <asp:Label runat="server" AssociatedControlID="MT"><b>meeting point : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="MT" ID="MT" class="form-control input-group"></asp:TextBox><br />




                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="meetingcreation5c" Text="Accept" />

                    

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

