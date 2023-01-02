<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ScheduleDef.aspx.cs" Inherits="GIU.ScheduleDef" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <br />
                            <h2>Schedule Defense</h2>

                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">

                                        <asp:Label runat="server" AssociatedControlID="student_id"><b>Student ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="student_id" ID="student_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="d"><b>Date: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="d" ID="d" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="t"><b>Time: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="t" ID="t" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="loc"><b>Loc: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="loc" ID="loc" class="form-control input-group"></asp:TextBox><br />

                                        &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="ScheduleDefense" Text="Accept" />



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

