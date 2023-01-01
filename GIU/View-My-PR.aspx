<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-My-PR.aspx.cs" Inherits="GIU.View_My_PR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>View My Progress Reports</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                    <asp:GridView ID="PR" runat="server" Visible="true" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10" >
                    </asp:GridView>
         


                     <asp:Label runat="server" ID="studentidlabel"><b>Student ID: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="studentid" ID="studentidbox"></asp:TextBox><br />


                    <asp:Label runat="server" ID="datelabel"><b>Date: </b></asp:Label><br />
                    <asp:TextBox runat="server" Placeholder="m/d/yyyy" Enabled="true" name="date" ID="datebox" ></asp:TextBox><br /><br />

                    
         
                     &nbsp;<asp:Button ID="viewPR" runat="server" OnClick="Button1_Click" Text="View" />


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
