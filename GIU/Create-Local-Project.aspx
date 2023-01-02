<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create-Local-Project.aspx.cs" Inherits="GIU.Create_Local_Porject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Create Local Project</h2>

</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">

    

        <br /><br />

        <asp:Label ID="cidlabel"  runat="server" > <b>Company ID:  </b></asp:Label><br />
    <asp:TextBox ID="cidtextbox" required="required" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="projlabel" runat="server" ><b>Project Code: </b></asp:Label><br />
    <asp:TextBox ID="projbox" required="required" runat="server" ></asp:TextBox><br /><br />

    <asp:Label ID="titlelabel" runat="server" ><b>Project Title: </b></asp:Label><br />
    <asp:TextBox ID="titlebox" required="required" runat="server"></asp:TextBox><br /><br />

    
    <asp:Label ID="desclabel" runat="server" ><b>Description: </b></asp:Label><br />
    <asp:TextBox ID="descbox" required="required" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="majorcodelabel" runat="server" ><b>Major Code: </b></asp:Label><br />
    <asp:TextBox ID="majorcodebox" required="required" runat="server"></asp:TextBox><br /><br />


        <asp:Button ID="createproj" runat="server" Text="Create" OnClick="createproj_Click" /><br /><br />

                        
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


