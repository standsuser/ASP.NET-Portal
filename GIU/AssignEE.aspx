

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignEE.aspx.cs" Inherits="GIU.AssignEE" %>
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

                    <asp:Label runat="server" AssociatedControlID="coord_id"><b>Coordinator ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="Coordinator ID" ID="coord_id" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="ee_id"><b>External Examiner ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="External Examiner ID" ID="ee_id" class="form-control input-group"></asp:TextBox><br />

                           <asp:Label runat="server" AssociatedControlID="p_code"><b>Project Code: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="Project Code" ID="p_code" class="form-control input-group"></asp:TextBox><br />
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="assign_EE" Text="Accept" />

                 

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

