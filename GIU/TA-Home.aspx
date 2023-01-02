<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TA-Home.aspx.cs" Inherits="GIU.TA_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <h2>Teaching Assistant Home</h2>
                            <br />
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">


                                        
                                        <asp:Button ID="createPR" runat="server" OnClick="PR_click" Text="Create Progress Report"  Width="220px" /> <br />  <br />
                                        <asp:Button ID="addtodo" runat="server" OnClick="addtodo_click" Text="Add to Meeting To-Do List" Width="220px" /> <br />  <br />
                             
                       

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
