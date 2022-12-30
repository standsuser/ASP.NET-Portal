<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpProgressReport.aspx.cs" Inherits="GIU.EmpProgressReport" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Employee Peogress Report</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                    <asp:Label runat="server" AssociatedControlID="e_eid"><b>Enter Employee ID </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="e_eid" ID="e_eid" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="s_sid"><b>Enter Staff ID </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="s_sid" ID="s_sid" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="d_location"><b> Enter Defense Location  </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="d_location" ID="d_location" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="emp_grade"><b> Enter Employee Grade </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="emp_grade" ID="emp_grade" class="form-control input-group"></asp:TextBox><br />

                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="Emp_ProgressReport" Text="Accept" />

                        
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