<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EE-Home.aspx.cs" Inherits="GIU.EE_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <h2>External Examiner Home</h2>
                            <br />
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">


                    
                                        <asp:Button ID="gradethesis" runat="server" OnClick="thesis_click" Text="Grade Thesis" Width="196px" /> <br />  <br />
                                        <asp:Button ID="gradedefense" runat="server" OnClick="defense_click" Text="Grade Defense" Width="196px" /> <br />  <br />

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
