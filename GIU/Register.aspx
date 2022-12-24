<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GIU.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <section id="main-content">
<section class="wrapper">
<div class="row">
<div class="col-lg-12">
<section class="panel">
<header class="panel-heading">
    <br /><br />
<h2>Registration Form<br /><br /><asp:Panel ID="idpass" runat="server" BackColor="Silver" BorderColor="#666666" BorderStyle="Solid" BorderWidth="5px" Visible="false" >


                      <asp:Label runat="server" ID="idpasslabel"><b> </b></asp:Label><br />

                        </asp:Panel><br /><br />


                </h2>
</header>

    <div class="panel-body">
        <div class="row">
            <div class="col-md-4 col-md-offset-1">
                <div class="form-group">
                   <!-- <asp:Label runat="server" AssociatedControlID="txttempname"><b>Name</b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" Enabled="true" name="BrandName" ID="txttempname" class="form-control input-sm"></asp:TextBox><br />-->
               
                   <asp:Label runat="server" AssociatedControlID="usertype"><b>User Type</b></asp:Label><br />
                    <asp:DropDownList ID="usertype" CssClass="form-control input-sm" runat="server"  AutoPostBack="true" OnSelectedIndexChanged="DropDownList_Changed">
                            <asp:ListItem Value="">Select</asp:ListItem>
                        <asp:ListItem Text="Students" />
                        <asp:ListItem Text="Companies" />
                        <asp:ListItem Text="Lecturers" />
                        <asp:ListItem Text="Teaching assistants" />
                        <asp:ListItem Text="External examiners" />
                        <asp:ListItem Text="Coordinators" />




                    </asp:DropDownList><br /><br />


                      <asp:Label runat="server" AssociatedControlID="username"><b>Username: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="myusername" visible="true" Enabled="true" name="username" ID="username" class="form-control input-group"></asp:TextBox><br />

                    
                      <asp:Label runat="server" AssociatedControlID="email"><b>Email: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="email@gmail.com" visible="true" Enabled="true" name="email" ID="email" class="form-control input-group" TextMode="Email"></asp:TextBox><br />

                

                    <asp:Label runat="server" ID="phonenumberlabel"><b>Phone Number: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="0100001001" visible="true" Enabled="true" name="phonenumber" ID="phonenumber" TextMode="Phone" ></asp:TextBox><br />


                    
                    <!--Student begin-->
                        <hr />
                     <asp:Panel ID="student" runat="server" Visible="false">

                      <asp:Label runat="server" visible="true" ID="fnamelabel"><b>First Name: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="John" visible="true" Enabled="true" name="fname" ID="fname" ></asp:TextBox><br /><br />

                     <asp:Label runat="server" visible="true" ID="lnamelabel"><b>Last Name: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="Smith" visible="true" Enabled="true" name="lname" ID="lname" ></asp:TextBox><br /><br />

                         
                     <asp:Label runat="server" visible="true" ID="majorcodelabel0"><b>Major Code: </b></asp:Label><br />
                    <asp:TextBox runat="server" required="required" placeholder="123" visible="true" Enabled="true" name="majorcode" ID="majorcode" ></asp:TextBox>
                         <br />  <br />

                     <asp:Label runat="server" visible="true" ID="doblabel"><b>Date of Birth: </b></asp:Label><br />
                         <asp:TextBox ID="dateofbirth"  required="required" placeholder="3/10/2000" visible="true" Enabled="true" runat="server" TextMode="Date"></asp:TextBox>
                         <br />   <br />

                         
                     <asp:Label runat="server" visible="true" ID="addresslabel"><b>Address: </b></asp:Label><br />
                         <asp:TextBox ID="inputaddress"  required="required" placeholder="street,area,city" visible="true" Enabled="true" runat="server"></asp:TextBox>
                         <br />   <br />

                         
                     <asp:Label runat="server" visible="true" ID="semesterlabel"><b>Semester: </b></asp:Label><br />
                         <asp:TextBox ID="inputsemester"  required="required" placeholder="1/2/3..." visible="true" Enabled="true" runat="server" TextMode="Number"></asp:TextBox>
                         <br />   <br />

                         
                     <asp:Label runat="server" visible="true" ID="gpalabel"><b>GPA: </b></asp:Label><br />
                         <asp:TextBox ID="inputgpa"  required="required" placeholder="0.7" visible="true" Enabled="true" runat="server" TextMode="Number"></asp:TextBox>
                         <br />   <br />

                  
                          </asp:Panel>



























                     &nbsp;<asp:Button ID="submitreg" runat="server" OnClick="Button1_Click" Text="Submit" />

                      
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


