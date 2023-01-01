<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update-My-Defense.aspx.cs" Inherits="GIU.Update_My_Defense" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Update My Defense</h2>

</header>
    <br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         


                     <asp:Label runat="server" ID="studentidlabel"><b>Student ID: </b></asp:Label><br />
                    <asp:TextBox runat="server"  required="required" Enabled="true" name="studentid" ID="studentidbox"></asp:TextBox><br />

                    
                    <asp:Label runat="server" ID="contentlabel"><b>Defense Content: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="content" ID="contentbox" TextMode="MultiLine"></asp:TextBox><br /><br />


                    
         
                     &nbsp;<asp:Button ID="updatedefense" runat="server" OnClick="updatedefense_Click" Text="Update" />


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
