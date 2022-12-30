<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeDefense.aspx.cs" Inherits="GIU.GradeDefense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Grade Defense</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                    <asp:Label runat="server" AssociatedControlID="c_cid"><b>Enter company ID </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="c_cid" ID="c_cid" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="s_id"><b>Enter Student ID </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="s_id" ID="s_id" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="d_location"><b> Enter Defense Location </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="d_location" ID="d_location" class="form-control input-group"></asp:TextBox><br />
                   
                     <asp:Label runat="server" AssociatedControlID="c_grade"><b> Enter Company Grade </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="c_grade" ID="c_grade" class="form-control input-group"></asp:TextBox><br />
                   
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="CompanyGradedefense" Text="Accept" />



                        
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


