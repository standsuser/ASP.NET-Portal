<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TACreatePR.aspx.cs" Inherits="GIU.TACreatePR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <br />
                            <h2>Create Progress Report for Student</h2>

                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">

                                        <asp:Label runat="server" AssociatedControlID="s_id"><b>Student ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="s_id" ID="s_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="ta_id"><b>TA ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="ta_id" ID="ta_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="d"><b>Date: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="d" ID="d" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="c"><b>Content: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="c" ID="c" class="form-control input-group"></asp:TextBox><br />

                                        &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="CreatePR" Text="Accept" />



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

