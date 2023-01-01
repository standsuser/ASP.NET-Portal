<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Company-Home.aspx.cs" Inherits="GIU.Company_Home" %>
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


                                        <asp:Button ID="addemp" runat="server" OnClick="addemp_click" Text="Add Employee" Width="196px" />  <br />  <br />
                                        <asp:Button ID="createproj" runat="server" OnClick="creatproj_click" Text="Create Local Project" Width="196px" />


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
