<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TAAddToDo.aspx.cs" Inherits="GIU.TAAddToDo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section class="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <br />
                            <br />
                            <h2>Add To Do List to a Meeting</h2>

                        </header>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">

                                        <asp:Label runat="server" AssociatedControlID="m_id"><b>Meeting ID: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="Meeting ID" ID="m_id" class="form-control input-group"></asp:TextBox><br />

                                        <asp:Label runat="server" AssociatedControlID="tdl"><b>To Do List: </b></asp:Label><br />
                                        <asp:TextBox runat="server" required="required" Enabled="true" name="to Do List" ID="tdl" class="form-control input-group"></asp:TextBox><br />

                                  
                                        &nbsp;<asp:Button ID="okbutton" runat="server" OnClick="AddTODO" Text="Accept" />



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

