<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmpThesisGrade.aspx.cs" Inherits="GIU.EmpThesisGrade" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Employee Thesis Grade</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                    <asp:Label runat="server" AssociatedControlID="emp_id"><b>Enter Employee ID </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="emp_id" ID="emp_id" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="s_sid"><b>Enter Student Id </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="s_sid" ID="s_sid" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="t_title"><b> Enter Thesis Title </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="t_title" ID="t_title" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="emp_grade"><b> Enter Employee Grade </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="emp_grade" ID="emp_grade" class="form-control input-group"></asp:TextBox><br />
                    
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="EmployeeGradeThesis" Text="Accept" />

                        
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
