<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignTa.aspx.cs" Inherits="GIU.AssignTa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <br />
                            <h2>See Users</h2>

                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">

                                        <asp:Label runat="server" AssociatedControlID="coordinator_id"><b>Coordinator ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Coordinator ID" ID="coordinator_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="TA_id"><b>TA ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Ta_id" ID="TA_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="pc"><b>Project Code: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Project_code" ID="pc" class="form-control input-group"></asp:TextBox><br />

                                        &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="Assign_tas" Text="Accept" />

                                       

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

