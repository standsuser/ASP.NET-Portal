<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GradeProgressReport.aspx.cs" Inherits="GIU.GradeProgressReport" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

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

                    <asp:Label runat="server" AssociatedControlID="c_cid"><b>Enter company Id </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="c_cid" ID="c_cid" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="s_sid"><b>Enter Student Id </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="s_sid" ID="s_sid" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="date_time"><b> Enter Date  </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="date_time" ID="date_time" class="form-control input-group"></asp:TextBox><br />
                   
                     <asp:Label runat="server" AssociatedControlID="c_grade"><b> Enter Company Grade </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="c_grade" ID="c_grade" class="form-control input-group"></asp:TextBox><br />
                   
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="CompanyGradePR" Text="Accept" />



                        
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



