<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-BP-Grade.aspx.cs" Inherits="GIU.View_BP_Grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>View My Bachelor Project Grade</h2>

</header>
    <br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                    <asp:GridView ID="bpgrade" runat="server" Visible="true" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10" >
                    </asp:GridView>

                     <asp:Label runat="server" ID="studentidlabel"><b>Student ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="studentid" ID="studentidbox"></asp:TextBox><br /><br />


         
                     &nbsp;<asp:Button ID="viewbpgrade" runat="server" OnClick="viewbpgrade_Click" Text="View" />


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


