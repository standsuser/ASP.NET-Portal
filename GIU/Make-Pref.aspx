<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Make-Pref.aspx.cs" Inherits="GIU.Make_Pref" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<header class="panel-heading">
      <br />
<h2>Make Preferences</h2>

</header>


    <asp:Label ID="sidlabel"  runat="server" > <b>Student ID:  </b></asp:Label><br />
    <asp:TextBox ID="sidtextbox" required="required" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="bcodelabel" runat="server" ><b>Bachelor Code: </b></asp:Label><br />
    <asp:TextBox ID="bachelorcodebox" required="required" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="prefnumlabel" runat="server" ><b>Preference Number: </b></asp:Label><br />
    <asp:TextBox ID="prefnumbox" required="required" runat="server"></asp:TextBox><br /><br />



    <asp:Button ID="submitpref" runat="server" Text="Submit" OnClick="submitpref_Click" /><br /><br />



</asp:Content>
