<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student-Home.aspx.cs" Inherits="GIU.Student_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">





    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <h2>Student Home</h2>
                            <br />
                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">


                                        <asp:Button ID="makepref" runat="server" OnClick="makepref_click" Text="Make Preferences" Width="196px" /> <br /> <br />
                                        <asp:Button ID="viewthesis" runat="server" OnClick="viewthesis_click" Text="View My Thesis" Width="196px" /><br /> <br />
                                        <asp:Button ID="submitthesis" runat="server" OnClick="submitthesis_click" Text="Submit My Thesis" Width="196px" /><br /> <br />
                                        <asp:Button ID="viewpr" runat="server" OnClick="viewpr_click" Text="View My Progress Reports"  Width="196px" /><br /> <br />
                                        <asp:Button ID="viewdefense" runat="server" OnClick="viewdefense_click" Text="View My Defense"  Width="196px" /><br /> <br />
                                        <asp:Button ID="updatedefense" runat="server" OnClick="updatedefense_click" Text="Update My Defense"  Width="196px" /><br /> <br />
                                        <asp:Button ID="viewbpgrade" runat="server" OnClick="viewbpgrade_click" Text="View Bachelor Project Grade" Width="196px" /><br /> <br />
                                        <asp:Button ID="viewnotbooked" runat="server" OnClick="viewnotbooked_click" Text="View Unbooked Meetings" Width="196px" /><br /> <br />
                                        <asp:Button ID="book" runat="server" OnClick="book_click" Text="Book Meeting" Width="196px" /><br /> <br />
                                        <asp:Button ID="viewbooked" runat="server" OnClick="viewbook_click" Text="View Booked Meeting" Width="196px" /><br /> <br />


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

