<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="assignEmp.aspx.cs" Inherits="GIU.assignEmp" %>

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

                    <asp:Label runat="server" AssociatedControlID="b_code"><b>Enter Bachelor Code </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="b_code" ID="b_code" class="form-control input-group"></asp:TextBox><br />
                   
                    <asp:Label runat="server" AssociatedControlID="s_id"><b>Enter Staff Id </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="s_id" ID="s_id" class="form-control input-group"></asp:TextBox><br />
                    
                    <asp:Label runat="server" AssociatedControlID="c_cid"><b> Enter Company Id </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="c_cid" ID="c_cid" class="form-control input-group"></asp:TextBox><br />
                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="assign_Employee" Text="Accept" />

                        
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

