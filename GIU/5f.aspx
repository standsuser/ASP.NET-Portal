<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="5f.aspx.cs" Inherits="GIU._5f" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>View Free External Examiners</h2>

</header>
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                     <asp:Label runat="server" ID="userid"><b>View external examiners that are not recommended to any academic local projects yet</b></asp:Label><br /><br />
                    <asp:GridView ID="freeEE" runat="server" Visible="true" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10" >
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
