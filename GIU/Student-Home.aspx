<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student-Home.aspx.cs" Inherits="GIU.Student_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





        <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
    <br />
<h2>Student Home</h2>
    <br />
</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">


                    <asp:Label runat="server" AssociatedControlID="txttempname"><b>Name</b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txttempname" class="form-control input-group"></asp:TextBox><br />
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

