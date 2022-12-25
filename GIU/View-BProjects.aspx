<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="View-BProjects.aspx.cs" Inherits="GIU.View_BProjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Bachelor Projects</h2>

</header>
    <h3>Details: </h3><br /><br />
    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
         
                    <asp:GridView ID="bprojects" runat="server" Visible="true" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10" >
                    </asp:GridView>
         


                     <asp:Label runat="server" ID="userid"><b>User ID: </b></asp:Label><br />
                    <asp:TextBox runat="server"  Enabled="true" name="userids" ID="userids"></asp:TextBox><br />

                     <asp:Label runat="server" ID="ptype"><b>Project Type: </b></asp:Label><br />
                    <asp:DropDownList ID="ptypes" runat="server">
                        <asp:ListItem Text="select" />
                        <asp:ListItem Text="academic" />
                        <asp:ListItem Text="industrial" />

                    </asp:DropDownList>
         
                                         &nbsp;<asp:Button ID="submitreg" runat="server" OnClick="Button1_Click" Text="Submit" />


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
