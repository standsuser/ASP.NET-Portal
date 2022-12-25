<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="GIU.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




      
    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Profile</h2>

</header>
    <h3>Details: </h3><br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                    <asp:GridView ID="profile" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10">
                    </asp:GridView>
         
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
