<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="5b.aspx.cs" Inherits="GIU._5b" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Specify Thesis Deadline For All Students</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                 <asp:Label runat="server" AssociatedControlID="dt"><b>deadline : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="dt" ID="dt" class="form-control input-group"></asp:TextBox><br />




                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="deadlineofallstudents5b" Text="Accept" />

                    

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
