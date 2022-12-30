<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EEGradeThesis.aspx.cs" Inherits="GIU.EEGradeThesis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <br />
                            <h2>Grade Thesis</h2>

                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">

                                        <asp:Label runat="server" AssociatedControlID="ee_id"><b>External Examiner ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="External Examiner ID" ID="ee_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="student_id"><b>Student ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Student id" ID="student_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="tt"><b>Thesis Title: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Thesis Title" ID="tt" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="ee_grade"><b>External Examiner Grade: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="External Examiner Grade" ID="ee_grade" class="form-control input-group"></asp:TextBox><br />

                                        &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="GradeThesis" Text="Accept" />



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

