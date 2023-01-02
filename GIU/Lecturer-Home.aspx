<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lecturer-Home.aspx.cs" Inherits="GIU.Lecturer_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <h2>Company Home</h2>
                            <br />
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">


                                        
                                        <asp:Button ID="createproj" runat="server" OnClick="creatproj_click" Text="Create Local Project" Width="196px" /> <br />  <br />
                                        <asp:Button ID="deadline" runat="server" OnClick="deadline_click" Text="Specify Thesis Deadline" Width="196px" /> <br />  <br />
                                        <asp:Button ID="createmeeting" runat="server" OnClick="createmeeting_click" Text="Create Meeting" Width="196px" /> <br />  <br />
                                        <asp:Button ID="addtodo" runat="server" OnClick="addtodo_click" Text="Add to Meeting To-Do" Width="196px" /> <br />  <br />
                                        <asp:Button ID="viewmeetings" runat="server" OnClick="viewmeetings_click" Text="View Meetings" Width="196px" /> <br />  <br />
                                        <asp:Button ID="viewEE" runat="server" OnClick="viewEE_click" Text="View Free External Examiners" Width="196px" /> <br />  <br />
                                        <asp:Button ID="recEE" runat="server" OnClick="recEE_click" Text="Recommend External Examiner" Width="208px" /> <br />  <br />
                                        <asp:Button ID="supervise" runat="server" OnClick="supervise_click" Text="Supervise Industrial Projects" Width="196px" /> <br />  <br />
                                        <asp:Button ID="gradethesis" runat="server" OnClick="gradethesis_click" Text="Grade Thesis" Width="196px" /> <br />  <br />
                                        <asp:Button ID="gradedefense" runat="server" OnClick="gradedefense_click" Text="Grade Defense" Width="196px" /> <br />  <br />
                                        <asp:Button ID="createPR" runat="server" OnClick="createPR_click" Text="Create Progress Report" Width="196px" /> <br />  <br />
                                        <asp:Button ID="gradePR" runat="server" OnClick="gradePR_click" Text="Grade Progress Report" Width="196px" /> <br />  <br />

                                        <br />
                                        <br />
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
