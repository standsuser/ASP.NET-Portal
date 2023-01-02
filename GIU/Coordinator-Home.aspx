<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Coordinator-Home.aspx.cs" Inherits="GIU.Coordinator_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <h2>Coordinator Home</h2>
                            <br />
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">


                                        
                                        <asp:Button ID="userdetails" runat="server" OnClick="seeuser_click" Text="See All Users"  Width="286px" /> <br />  <br />
                                        <asp:Button ID="assignstudents" runat="server" OnClick="assignstudents_click" Text="Assign All Students Projects" Width="286px" /> <br />  <br />
                                        <asp:Button ID="assignTA" runat="server" OnClick="assignTA_click" Text="Assign TAs"  Width="286px" /> <br />  <br />
                                        <asp:Button ID="EERec" runat="server" OnClick="EERec_click" Text="View External Examiner Recommendations" Width="286px" /> <br />  <br />
                                        <asp:Button ID="AssignEE" runat="server" OnClick="AssignEE_click" Text="Assign External Examiner to Project" Width="286px" /> <br />  <br />
                                        <asp:Button ID="scheduledef" runat="server" OnClick="scheduledef_click" Text="Schedule Defenses" Width="286px"/> <br />  <br />
                       

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
