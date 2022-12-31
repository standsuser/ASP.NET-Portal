<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Submit-My-Thesis.aspx.cs" Inherits="GIU.Submit_My_Thesis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Submit My Thesis</h2>

</header>
    <br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         


                     <asp:Label runat="server" ID="studentidlabel"><b>Student ID: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="studentid" ID="studentidbox"></asp:TextBox><br />


                    <asp:Label runat="server" ID="titlelabel"><b>Thesis Title: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="title" ID="titlebox"></asp:TextBox><br /><br />

                    
                    <asp:Label runat="server" ID="Label1"><b>PDF Document: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="pdf" ID="pdf" TextMode="MultiLine"></asp:TextBox><br /><br />


                    
         
                     &nbsp;<asp:Button ID="submitthesis" runat="server" OnClick="submitthesis_Click" Text="Submit" />


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

