<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GIU.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    
    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Login</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="email"><b>Email: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="Email" ID="email" class="form-control input-group"></asp:TextBox><br />

                           <asp:Label runat="server" AssociatedControlID="password"><b>Password: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" TextMode="Password" name="password" ID="password" class="form-control input-group"></asp:TextBox><br />
                     &nbsp;<asp:Button ID="loginbutton" runat="server" OnClick="login_Click" Text="Login" />
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










