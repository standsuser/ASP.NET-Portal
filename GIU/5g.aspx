<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="5g.aspx.cs" Inherits="GIU._5g" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Reccomend External Examiners</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

                 <asp:Label runat="server" AssociatedControlID="L_id"><b>lecturer ID: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="L_id" ID="L_id" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="P_code"><b>project code: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="P_code" ID="P_code" class="form-control input-group"></asp:TextBox><br />

                     <asp:Label runat="server" AssociatedControlID="ee_id"><b>External Examiner ID : </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="ee_id" ID="ee_id" class="form-control input-group"></asp:TextBox><br />




                    &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="RecommendEE5g" Text="Accept" />

                    

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
