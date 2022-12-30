
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CoSeeAll.aspx.cs" Inherits="GIU.UserSeeAll" %>
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

                    <asp:Label runat="server" AssociatedControlID="userType"><b>User Type: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="User Type" ID="userType" class="form-control input-group"></asp:TextBox><br />

                           <asp:Label runat="server" AssociatedControlID="userIdent"><b>User ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="User ID" ID="userident" class="form-control input-group"></asp:TextBox><br />
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="see_All" Text="Accept" />

                    <asp:GridView ID="Users_grid" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10">
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

