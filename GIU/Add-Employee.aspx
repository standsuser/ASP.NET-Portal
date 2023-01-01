<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add-Employee.aspx.cs" Inherits="GIU.Add_Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
      <br /><br />
<h2>Employee Peogress Report</h2>

</header>
                    <asp:GridView ID="employeegenerated" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderWidth="2px" CellSpacing="10">



            </asp:GridView>
            <br />




        <br /><br />

        <asp:Label ID="cidlabel"  runat="server" > <b>Company ID:  </b></asp:Label><br />
    <asp:TextBox ID="cidtextbox" required="required" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="emaillabel" runat="server" ><b>Email: </b></asp:Label><br />
    <asp:TextBox ID="emailbox" required="required" runat="server" TextMode="Email"></asp:TextBox><br /><br />

    <asp:Label ID="namelabel" runat="server" ><b>Employee Name: </b></asp:Label><br />
    <asp:TextBox ID="namebox" required="required" runat="server"></asp:TextBox><br /><br />

    
    <asp:Label ID="phonelabel" runat="server" ><b>Phone Number: </b></asp:Label><br />
    <asp:TextBox ID="phonebox" required="required" runat="server"></asp:TextBox><br /><br />

    <asp:Label ID="fieldlabel" runat="server" ><b>Field: </b></asp:Label><br />
    <asp:TextBox ID="fieldbox" required="required" runat="server"></asp:TextBox><br /><br />


        <asp:Button ID="addemp" runat="server" Text="Add" OnClick="addemp_Click" /><br /><br />

    

</asp:Content>
